using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.AddOn
{
    internal class FunctionsAddOn
    {

        //Apresentar Tabela AddOns juntamente com o campo [nome] dos Add_Ons_Grupo 
        public static void INFOAddOn(DataGridView _Datagridview)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select AddOns.ID, Descricao, Preco_Base, Add_Ons_Grupos.Nome as Categoria " +
                               "from AddOns " +
                               "left join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
                Models.IDManagment.IdAddOn = "";
            }
        }

        //Carregar informação da tabela AddOns segundo o ID selecionado apartir do evento cellClick na datagridview
        public static void LoadEditInfo(string _ID, TextBox _textbox1, TextBox _textbox2)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT * FROM AddOns where ID = '" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.GrupoAddOn = dr["fk_Add_Ons_Grupos_ID"].ToString();
                _textbox1.Text = dr["Descricao"].ToString();
                _textbox2.Text = dr["preco_base"].ToString();
            }
            con.Close();
        }

        //Carregar informação da tabela Modelo_AddOns segundo o ID selecionado apartir do evento cellClick na datagridview
        public static void LoadEditInfoAddOnMarca(string _ID, TextBox _marca, TextBox _modelo, TextBox _AddOn, TextBox _Preco)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Modelo_AddOns.ID, Marca.Nome as Marca, Modelo.Nome as Modelo, AddOns.Descricao as AddOnNome, Preco_Relacao " +
                               "from Modelo_AddOns " +
                               "join AddOns on AddOns.ID = Modelo_AddOns.fk_AddOns_ID " +
                               "join Marca_Modelo on Marca_Modelo.ID = Modelo_AddOns.fk_Marca_Modelo_ID " +
                               "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                               "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                               "where Modelo_AddOns.ID = '" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _marca.Text = dr["Marca"].ToString();
                _modelo.Text = dr["Modelo"].ToString();
                _AddOn.Text = dr["AddOnNome"].ToString();
                _Preco.Text = dr["Preco_Relacao"].ToString();
            }
            con.Close();
        }

        //Editar informação do registo especificado pelo ID na Tabela AddOns 
        public static void EditInfo(string _ID, string _textbox1, string _textbox2, string _Grupo)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "UPDATE AddOns SET " +
                "Descricao=@Descricao," +
                "preco_base=@preco_base, " +
                "fk_Add_Ons_Grupos_ID=@fk_Add_Ons_Grupos_ID " +
                " where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@Descricao", _textbox1);
            cmd.Parameters.AddWithValue("@preco_base", _textbox2);
            cmd.Parameters.AddWithValue("@fk_Add_Ons_Grupos_ID", _Grupo);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        //Inserir novo registo na tabela AddOns 
        public static void AddInfo(string _textbox1, string _textbox2, string _currentUserID, string _Grupo)
        {
            Models.IDManagment.IdAddOn = Models.IDManagment.InsereID("AddOns");


            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO AddOns(" +
                "id,Descricao,preco_base,fk_Utilizador_id,fk_Add_Ons_Grupos_ID,Date_Time_Adicionado)" +
                "VALUES (@id,@Descricao,@preco_base,@fk_Utilizador_id,@fk_Add_Ons_Grupos_ID,@Date_Time_Adicionado)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IdAddOn);
            cmd.Parameters.AddWithValue("@Descricao", _textbox1);
            cmd.Parameters.AddWithValue("@preco_base", _textbox2);
            cmd.Parameters.AddWithValue("@fk_Utilizador_id", _currentUserID);
            cmd.Parameters.AddWithValue("@fk_Add_Ons_Grupos_ID", _Grupo);
            cmd.Parameters.AddWithValue("@Date_Time_Adicionado", DateTime.Now.ToLocalTime());
            try
            {
                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Reveja os dados que inseriu", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Registo inserido", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            con.Close();

        }

        //Buscar ID Respetivo ao nome do grupo especificado na variavel
        public static void GroupId(string _group)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Add_Ons_Grupos.ID as IDGrupo " +
                           "From Add_Ons_Grupos " +
                           "where Add_Ons_Grupos.Nome = '" + _group + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.GrupoAddOn = dr["IDGrupo"].ToString();
            }
            con.Close();

        }

        //Buscar ID Respetivo à descrição do grupo especificado na variavel
        public static void AddOnId(string _Descricao)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select ID from AddOns where Descricao = '" + _Descricao + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.IDAddOn = dr["ID"].ToString();
            }
            con.Close();

        }

        //Apresentar campo [nome] da tabela Add_Ons_Grupos segundo o ID especificado na variavel
        public static void GroupLoad(string _fkID, ComboBox _txtGrupo)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Add_Ons_Grupos.Nome as Grupo " +
                           "From Add_Ons_Grupos " +
                           "where Add_Ons_Grupos.ID = '" + _fkID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _txtGrupo.Text = dr["Grupo"].ToString();
            }
            con.Close();

        }

        //Apresentar Tabela Modelo_AddOns 
        public static void INFOAddOnMarca(DataGridView _Datagridview, string _ID)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select Modelo_AddOns.ID, Marca.Nome as Marca, Modelo.Nome as Modelo, AddOns.Descricao, Preco_Relacao " +
                               "from Modelo_AddOns " +
                               "join AddOns on AddOns.ID = Modelo_AddOns.fk_AddOns_ID " +
                               "join Marca_Modelo on Marca_Modelo.ID = Modelo_AddOns.fk_Marca_Modelo_ID " +
                               "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                               "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                               "where Modelo_AddOns.fk_Marca_Modelo_ID = '" + _ID + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
                Models.IDManagment.IdAddOn = "";
            }
            Models.IDManagment.IdAddOnMarca = "";

            Models.FunctionsGeneral.EditDataGrid(_Datagridview);
        }

        //Inserir novo registo na tabela Modelo_AddOns 
        public static void AddInfoMarcaAddOn(string _Preco, string _AddOnsID, string _MarcaModelo)
        {
            Models.IDManagment.IdAddOnMarcaADD = Models.IDManagment.InsereID("Modelo_AddOns");


            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO Modelo_AddOns(" +
                "id,Preco_Relacao,fk_AddOns_id,fk_Marca_Modelo_ID)" +
                "VALUES (@id,@Preco_Relacao,@fk_AddOns_id,@fk_Marca_Modelo_ID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IdAddOnMarcaADD);
            cmd.Parameters.AddWithValue("@Preco_Relacao", _Preco);
            cmd.Parameters.AddWithValue("@fk_AddOns_id", _AddOnsID);
            cmd.Parameters.AddWithValue("@fk_Marca_Modelo_ID", _MarcaModelo);
            try
            {
                cmd.ExecuteScalar();
            }
            catch
            {
                MessageBox.Show("Reveja os dados que inseriu", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Registo inserido", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);


            con.Close();
        }

        //Editar informação do registo especificado pelo ID na Tabela Modelo_AddOns 
        public static void EditInfoAddMarca(string _ID, string _preco, string _AddOnID, string _MarcaModelo)
        {
            SqlConnection con = new
               SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "UPDATE Modelo_AddOns SET " +
                "Preco_Relacao=@Preco_Relacao," +
                "fk_AddOns_id=@fk_AddOns_id, " +
                "fk_Marca_Modelo_ID=@fk_Marca_Modelo_ID " +
                " where ID=@ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@Preco_Relacao", _preco);
            cmd.Parameters.AddWithValue("@fk_AddOns_id", _AddOnID);
            cmd.Parameters.AddWithValue("@fk_Marca_Modelo_ID", _MarcaModelo);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();

        }

        //Verificar se campo já existe apartir de stored procedure na BD
        public static bool VField(string _textbox, string _textbox2, string _Procedure, string _field, string _field2)
        {
            using (SqlConnection con =
                new SqlConnection(Models.Utils.conString))
            {
                SqlCommand cmd = new SqlCommand(_Procedure, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                cmd.Parameters.AddWithValue(_field, _textbox);
                cmd.Parameters.AddWithValue(_field2, _textbox2);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

    }
}
