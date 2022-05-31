using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewClient
{
    internal class ProductFilters
    {

        private static string _ID = "";
        public static string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private static string _IDExtensoes = "";
        public static string IDExtensoes
        {
            get { return _IDExtensoes; }
            set { _IDExtensoes = value; }
        }

        private static string _IDModExtensoes = "";
        public static string IDModExtensoes
        {
            get { return _IDModExtensoes; }
            set { _IDModExtensoes = value; }
        }

        private static double _PrecoMaquina = 0;
        public static double PrecoMaquina
        {
            get { return _PrecoMaquina; }
            set { _PrecoMaquina = value; }
        }

        private static double _PrecoMaquinaAddOn = 0;
        public static double PrecoMaquinaAddOn
        {
            get { return _PrecoMaquinaAddOn; }
            set { _PrecoMaquinaAddOn = value; }
        }

        private static double _PrecoTotal = 0;
        public static double PrecoTotal
        {
            get { return _PrecoTotal; }
            set { _PrecoTotal = value; }
        }

        private static string _IDSimulacao = "";
        public static string IDSimulacao
        {
            get { return _IDSimulacao; }
            set { _IDSimulacao = value; }
        }

        private static float _Preco;
        public static float Preco
        {
            get { return _Preco; }
            set { _Preco = value; }
        }

        private static string _NumImpressoras = "";
        public static string NumImpressoras
        {
            get { return _NumImpressoras; }
            set { _NumImpressoras = value; }
        }


        public static List<string> extensoes = new List<string>();
        public static List<string> ModelAddOnsID = new List<string>();

        public static List<Models.VMProduct> produtos = new List<Models.VMProduct>();



        private static string _Nome = "";
        public static string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        private static string _Email = "";
        public static string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }


        //#------------------------------------------------------------------------------------------------------------------#

        public static void ShowSimulacao(DataGridView _DataGridName, string _IDUser)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "Select Simulacoes.ID, FORMAT ( Data_Simulacao, 'dd/MM/yyyy ')  as [Data], FORMAT ( Data_Simulacao, 'HH:mm')  as [Hora], count(Equipamentos.fk_Maquinas_ID) as [Maquinas na Simulação] " +
                               "from Equipamentos " +
                               "join Simulacoes on Simulacoes.ID = Equipamentos.fk_Simulacoes_ID " +
                               "join Utilizador on Utilizador.ID = Simulacoes.fk_Utilizador_ID " +
                               "where Utilizador.ID = " + _IDUser +
                               "group by Simulacoes.ID, Utilizador.Nome,  Data_Simulacao ";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
            }
            ProductFilters.IDSimulacao = "";
        }

        public static List<string> ListCMB(string _Database)
        {
            List<string> al = new List<string>();

            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM " + _Database + " Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                al.Add(dr["Nome"].ToString());
            }
            con.Close();
            return al;
        }

        public static void LoadMachine(string _ID, Label _Dimensoes, Label _Preco, Label _Cor, PictureBox _Image, Label _Descricao)
        {
            Encoding ascii = Encoding.ASCII;
            Encoding unicode = Encoding.Unicode;

            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT * FROM Maquinas where id='" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _Cor.Text = dr["cor"].ToString();
                _Dimensoes.Text = dr["dimensoes"].ToString();
                _Preco.Text = dr["preco"].ToString() + "€";
                _Descricao.Text = dr["Descricao"].ToString();
                byte[] data = dr["Produto_Imagem"].ToString().Length > 0 ? (byte[])(dr["Produto_Imagem"]) : Maquinas.FunctionsMaq.ConvertImageToBytes(Properties.Resources.editcolu);
                MemoryStream mem = new MemoryStream(data);
                _Image.Image = Image.FromStream(mem);
                Models.IDManagment.fkMarca_Modelo = dr["fk_Marca_Modelo_ID"].ToString();
                ProductFilters.Preco = float.Parse(dr["preco"].ToString());
            }
            con.Close();
        }

        public static void LoadImMarcaMod(string _ID, Label _MarcaModelo)
        {
            SqlConnection con =
                   new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Marca.Nome as Marca,  Modelo.Nome as Modelo " +
                           "from Marca_Modelo " +
                           "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                           "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                           "where Marca_Modelo.ID = '" + _ID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _MarcaModelo.Text = "IMPRESSORA " + dr["Marca"].ToString() + " " + dr["Modelo"].ToString();
            }
            con.Close();
        }

        //#------------------------------------------------------------------------------------------------------------------#
        public static void ShowAddOnsGrupo(DataGridView _DataGridName, string _grupo, string _Modelo)
        {
            using (SqlConnection con =
             new SqlConnection(Models.Utils.conString))
            {
                con.Open();
                string query = "select AddOns.ID, Descricao as Descrição, Add_Ons_Grupos.Nome as Grupo, Modelo_AddOns.Preco_Relacao as [Preço]  " +
                               "from AddOns " +
                               "join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID " +
                               "join Modelo_AddOns on Modelo_AddOns.fk_AddOns_ID = AddOns.ID " +
                               "where Add_Ons_Grupos.Nome = '" + _grupo + "' and Modelo_AddOns.fK_Marca_Modelo_ID = '" + _Modelo + "' order by AddOns.ID";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    _DataGridName.Rows.Add(dr["ID"], dr["Descrição"], dr["Grupo"], dr["Preço"]);
                }
                con.Close();
            }
        }

        public static void ShowAddOns(DataGridView _datagrid, string _Modelo)
        {
            using (SqlConnection con =
             new SqlConnection(Models.Utils.conString))
            {
                con.Open();
                string query = "select AddOns.ID, Descricao as Descrição, Add_Ons_Grupos.Nome as Grupo, Modelo_AddOns.Preco_Relacao as [Preço]" +
                               "from AddOns " +
                               "join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID " +
                               "join Modelo_AddOns on Modelo_AddOns.fk_AddOns_ID = AddOns.ID " +
                               "where Modelo_AddOns.fK_Marca_Modelo_ID = '" + _Modelo + "' order by AddOns.ID";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    _datagrid.Rows.Add(false, dr["ID"], dr["Descrição"], dr["Grupo"], dr["Preço"]);
                }
                con.Close();
            }
        }

        public static void CmbOrderItems(ToolStripComboBox _cmb)
        {
            _cmb.Items.Add("Preço ASCENDENTE");
            _cmb.Items.Add("Preço DESCENDENTE");
        }

        public static void CmbInsertM(ToolStripComboBox _cmb)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM Marca Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }
        }

        public static void CmbInsertMod(ToolStripComboBox _cmb, string _Marca)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"SELECT Modelo.Nome 
                            FROM Modelo
                            join Marca_Modelo on Marca_Modelo.fk_Modelo_ID = Modelo.ID
                            join Marca on Marca_Modelo.fk_Marca_ID = Marca.ID
                            where Marca.Nome = '" + _Marca + "' " +
                            "Group by Modelo.Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }
        }

        //#------------------------------------------------------------------------------------------------------------------#


        public static void SortPrices(DataGridView _DataGridName, string _order)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "order by Preco " + _order;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }
        public static void MarcaSelect(DataGridView _DataGridName, string _order)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where mar.Nome = '" + _order + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        public static void MarcaModeloSelect(DataGridView _DataGridName, string _Marca, string _Modelo)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where mar.Nome = '" + _Marca + "' and modl.Nome = '" + _Modelo + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        public static void PrecoMarcaModSelect(DataGridView _DataGridName, string _Preco, string _marca, string _modelo)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where mar.Nome = '" + _marca + "'  and modl.Nome = '" + _modelo + "' order by Preco " + _Preco ;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        public static void PrecoMarcaSelect(DataGridView _DataGridName, string _Preco, string _marca)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select maq.ID, maq.Dimensoes, maq.Cor, modl.Nome as [Modelo], mar.Nome as [Marca], Preco " +
                                "from Maquinas as maq " +
                                "join Marca_Modelo as marModl on marModl.ID = maq.fk_Marca_Modelo_ID " +
                                "join Marca as mar on mar.ID = marModl.fk_Marca_ID " +
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID " +
                                "where mar.Nome = '" + _marca + "' order by Preco " + _Preco;
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }



        //#------------------------------------------------------------------------------------------------------------------#

        public static void OverlayFilter(DataGridView _DataGridName, string _Order, string _Marca, string _Modelo)
        {
            string order;
            if (_Order == "Preço ASCENDENTE")
            {
                order = "asc";
            }
            else
            {
                order = "desc";
            }

            if (_Order != "" && _Marca != "" && _Modelo != "")
            {
                ProductFilters.PrecoMarcaModSelect(_DataGridName, order, _Marca, _Modelo);
            }
            else if (_Modelo == "")
            {
                ProductFilters.PrecoMarcaSelect(_DataGridName, order, _Marca);
            }
            else if (_Order == "")
            {
                ProductFilters.MarcaModeloSelect(_DataGridName, _Marca, _Modelo);
            }
            else if (_Order == "" && _Modelo == "")
            {
                ProductFilters.MarcaSelect(_DataGridName, _Marca);
            }
            else if(_Marca == "" && _Modelo == "")
            {
                ProductFilters.SortPrices(_DataGridName, order);
            }


        }

        //#------------------------------------------------------------------------------------------------------------------#


        public static void Simulacao()
        {
            Models.IDManagment.IdSimulacao = Models.IDManagment.InsereID("Simulacoes");

            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO Simulacoes(" +
                "id,Data_Simulacao,fk_Utilizador_id)" +
                "VALUES (@id,@Data_Simulacao,@fk_Utilizador_id)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IdSimulacao);
            cmd.Parameters.AddWithValue("@Data_Simulacao", DateTime.Now.ToLocalTime());
            cmd.Parameters.AddWithValue("@fk_Utilizador_ID", Models.CurrentUser.IDUser);
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
            con.Close();
        }

        public static void Equipamentos()
        {
            Models.IDManagment.IdEquipamento = Models.IDManagment.InsereID("Equipamentos");

            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO Equipamentos(" +
                "id,Preco,fk_Maquinas_id,fk_Simulacoes_ID)" +
                "VALUES (@id,@Preco,@fk_Maquinas_id,@fk_Simulacoes_ID)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IdEquipamento);
            cmd.Parameters.AddWithValue("@Preco", ProductFilters.Preco);
            cmd.Parameters.AddWithValue("@fk_Maquinas_id", ProductFilters.ID);
            cmd.Parameters.AddWithValue("@fk_Simulacoes_ID", Models.IDManagment.IdSimulacao);
            try
            {
                cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show("Reveja os dados que inseriu", "Erro",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Close();
        }

        public static void AddOnsEquip(string _IDAddOns, double _Preco, int _quantidade)
        {
            Models.IDManagment.IDAddOnsMaquinas = Models.IDManagment.InsereID("AddOns_Equip");

            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO AddOns_Equip(" +
                "id,fk_Modelo_AddOns_id,fk_Equipamentos_ID,Preco_Simulacao,Quantidade)" +
                "VALUES (@id,@fk_Modelo_AddOns_id,@fk_Equipamentos_ID,@Preco_Simulacao,@Quantidade)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Models.IDManagment.IDAddOnsMaquinas);
            cmd.Parameters.AddWithValue("@fk_Modelo_AddOns_id", _IDAddOns);
            cmd.Parameters.AddWithValue("@fk_Equipamentos_ID", Models.IDManagment.IdEquipamento);
            cmd.Parameters.AddWithValue("@Preco_Simulacao", _Preco);
            cmd.Parameters.AddWithValue("@Quantidade", _quantidade);
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
            con.Close();
        }

        public static void ListCycle(List<Models.VMProduct> _MyList, List<string> _Mylist2)
        {
            for (int i = 0; i < _MyList.Count; i++)
            {
                AddOnsEquip(_Mylist2[i], _MyList[i].preco, _MyList[i].quantidade);
            }

        }

        public static void MaquinasInSimulacao(string _ID)
        {
            SqlConnection con =
                       new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "Select Count(ID) as QUANTI " +
                           "from Equipamentos " +
                           "where fk_Simulacoes_ID = '" + _ID + "' " +
                           "group by fk_Simulacoes_ID";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ProductFilters.NumImpressoras = dr["QUANTI"].ToString();
            }
            con.Close();
        }

        public static void ExtensoesID(string _ID, string _IDAddOns)
        {
            SqlConnection con =
                       new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"Select ID 
                            FROM Modelo_AddOns
                            WHERE fk_Marca_Modelo_ID = '" + _ID + "' AND fk_AddOns_ID = '" + _IDAddOns + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               ProductFilters.IDModExtensoes = dr["ID"].ToString();

            }
            con.Close();
        }
        
            
        

        //#------------------------------------------------------------------------------------------------------------------#

        public static List<string> MaquinasList(string _ID)
        {
            List<string> al = new List<string>();

            SqlConnection con =
                   new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "Select fk_Maquinas_ID as ID " +
                           "from Equipamentos " +
                           "where fk_Simulacoes_ID = '" + _ID + "' " +
                           "group by fk_Maquinas_ID";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                al.Add(dr["ID"].ToString()); 
            }
            con.Close();
            return al;
        }
        public static List<string> EquipamentosList(string _ID)
        {
            List<string> al = new List<string>();

            SqlConnection con =
                   new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "Select Equipamentos.ID as id " +
                           "from Equipamentos " +
                           "where fk_Simulacoes_ID = " + _ID +
                           "group by  Equipamentos.ID";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                al.Add(dr["id"].ToString());
            }
            con.Close();
            return al;
        }

        public static void LoadAddOnsSimulacao(DataGridView _DataGridName, string _ID)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select AddOns.ID, Descricao as Descrição, Add_Ons_Grupos.Nome as Grupo, Modelo_AddOns.Preco_Relacao as [Preço], count(AddOns.ID) as [AddOn Quantidade] " +
                               "from AddOns " +
                               "join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID " +
                               "join Modelo_AddOns on Modelo_AddOns.fk_AddOns_ID = AddOns.ID " +
                               "join AddOns_Equip on AddOns_Equip.fk_Modelo_AddOns_ID = Modelo_AddOns.ID " +
                               "where AddOns_Equip.fk_Equipamentos_ID = " + _ID + 
                               " group by AddOns.ID, Descricao, Add_Ons_Grupos.Nome, Modelo_AddOns.Preco_Relacao";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        public static void LoadAllSimulacao(DataGridView _DataGridName, string _ID)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = "select AddOns.ID, Descricao as Descrição, Add_Ons_Grupos.Nome as Grupo, Modelo_AddOns.Preco_Relacao as [Preço], count(AddOns.ID) as [AddOn Quantidade] " +
                               "from AddOns " +
                               "join Add_Ons_Grupos on Add_Ons_Grupos.ID = AddOns.fk_Add_Ons_Grupos_ID " +
                               "join Modelo_AddOns on Modelo_AddOns.fk_AddOns_ID = AddOns.ID " +
                               "join AddOns_Equip on AddOns_Equip.fk_Modelo_AddOns_ID = Modelo_AddOns.ID " +
                               "where AddOns_Equip.fk_Equipamentos_ID = " + _ID +
                               " group by AddOns.ID, Descricao, Add_Ons_Grupos.Nome, Modelo_AddOns.Preco_Relacao";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        //#------------------------------------------------------------------------------------------------------------------#

        public static void PrecoAddMaq(string _idEquip, string _idSimulacao)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"select equip.fk_Maquinas_ID as [ID], equip.Preco as [Preço máquina],
                            (
                                select SUM(addOnEquip.Preco_Simulacao * addOnEquip.Quantidade)
                                from AddOns_Equip as addOnEquip
								JOIN Maquinas on Maquinas.ID = equip.fk_Maquinas_ID
                                WHERE addOnEquip.fk_Equipamentos_ID = equip.ID 
                            ) as [Total AddOns]
                            from Equipamentos as equip
                            where equip.fk_Simulacoes_ID = '" + _idSimulacao  + "' and equip.ID = '" + _idEquip + "' " +
                            "group by equip.fk_Maquinas_ID, equip.ID, equip.Preco";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductFilters.PrecoMaquina = Convert.ToDouble(dr[1]);
                ProductFilters.PrecoMaquinaAddOn =  Convert.ToDouble(dr[2]);
            }

            
        }

        public static void PrecoTotalSimulacao(string _idSimulacao)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"select
                            (
                                select SUM(Equipamentos.Preco)
                                from Equipamentos
                                where Equipamentos.fk_Simulacoes_ID = sim.ID
                            ) as [Total Equipamentos],

                            (
                                select SUM (addon.Preco_Simulacao * addon.Quantidade)
                                from AddOns_Equip as addon
                                join Equipamentos as equip on equip.ID = addon.fk_Equipamentos_ID
                                where equip.fk_Simulacoes_ID = sim.ID
                            ) as [Total AddOns]
                            from Simulacoes as sim
                            where sim.ID =" + _idSimulacao;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductFilters.PrecoTotal = (Convert.ToDouble(dr[0]) + (Convert.ToDouble(dr[1])));
            }


        }


        //#------------------------------------------------------------------------------------------------------------------#


        public static void UserPDF(string _idSimulacao)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = @"Select Utilizador.Nome, Utilizador.Email 
                            from Simulacoes
                            JOIN Utilizador on Utilizador.ID = Simulacoes.fk_Utilizador_ID
                            WHERE Simulacoes.ID = " + _idSimulacao;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ProductFilters.Nome = dr["Nome"].ToString();
                ProductFilters.Email = dr["Email"].ToString();
            }


        }

        public static void LoadSimulacaoEquipamentos(DataGridView _DataGridName, string _ID)
        {
            using (SqlConnection con =
               new SqlConnection(Models.Utils.conString))
            {
                DataTable dt = new DataTable();
                BindingSource bs = new BindingSource();
                string query = @"select equip.fk_Maquinas_ID as ID, Marca.Nome,  Modelo.Nome, maq.Cor, maq.Dimensoes, maq.Preco, count (equip.fk_Maquinas_ID) as [Quantidade]
                                from Equipamentos as equip
                                left join Maquinas as maq on maq.ID = equip.fk_Maquinas_ID
                                left join Marca_Modelo on maq.fk_Marca_Modelo_ID = Marca_Modelo.ID
                                left join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID
                                left join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID
                                where equip.fk_Simulacoes_ID = " + _ID +
                                " group by equip.fk_Maquinas_ID, Marca.Nome, Modelo.Nome, maq.Cor, maq.Dimensoes, maq.Preco";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _DataGridName.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }





    }
}
