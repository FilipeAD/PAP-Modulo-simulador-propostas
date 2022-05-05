using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.Maquinas
{
    internal class FunctionsMaq
    {
        public static void AddInfo(string _ID, string _Cor, string _Dimensoes, string _Preco, string _fkMM, string _currentUserID, PictureBox _Image)
        {

            if (string.IsNullOrWhiteSpace(_Cor) | string.IsNullOrWhiteSpace(_Dimensoes) | string.IsNullOrWhiteSpace(_Preco))
            {
                MessageBox.Show("Tem de preencher todos os campos", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SqlConnection con = new
                SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "INSERT INTO maquinas(" +
                "id,cor,dimensoes,preco,fk_Marca_modelo_id,fk_Utilizador_id,Date_Time_Added,Produto_Imagem)" +
                "VALUES (@id,@cor,@dimensoes,@preco,@fk_marca_modelo_id,@fk_Utilizador_id,@Date_Time_Added,@Produto_Imagem)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@cor", _Cor);
            cmd.Parameters.AddWithValue("@dimensoes", _Dimensoes);
            cmd.Parameters.AddWithValue("@preco", _Preco);
            cmd.Parameters.AddWithValue("@fk_marca_modelo_id", _fkMM);
            cmd.Parameters.AddWithValue("@fk_Utilizador_id", _currentUserID);
            cmd.Parameters.AddWithValue("@Date_Time_Added", DateTime.Now.ToLocalTime());
            cmd.Parameters.AddWithValue("@Produto_Imagem", ConvertImageToBytes(_Image.Image));
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

        public static void CmbInsertM(string _Database,  ComboBox _cmb)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Nome FROM " + _Database + " Group by Nome ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Nome"].ToString());
            }
        }

        public static void CmbInsertMM(ComboBox _cmb, string _cmb2)
        {
            _cmb.Items.Clear();
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "SELECT Modelo.Nome as Modelo FROM Marca_Modelo " +
                            "INNER JOIN Modelo on Marca_Modelo.fk_Modelo_ID = Modelo.ID " +
                            "INNER JOIN Marca on Marca_Modelo.fk_Marca_ID = Marca.ID " +
                            "where Marca.Nome = '" + _cmb2 + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                _cmb.Items.Add(dr["Modelo"].ToString());
            }
        }

        public static void IDMM(string _cmb, string _cmb2)
        {
            SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "select Marca_Modelo.ID as IDMarcaModelo " +
                            "from Marca_Modelo " +
                            "join Marca on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                            "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                            "where Marca.Nome = '" + _cmb + "' and Modelo.Nome = '" + _cmb2 + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Models.Utils.Marca_Modelo = dr["IDMarcaModelo"].ToString();
            }
            con.Close();

        }


        public static void LoadCMB(TextBox _cmb, TextBox _cmb2, string _ID)
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
                _cmb.Text = dr["Marca"].ToString();
                _cmb2.Text = dr["Modelo"].ToString();
            }
            con.Close();
        }

        public static void LoadMachine(string _ID, TextBox _Cor, TextBox _Dimensoes, TextBox _Preco)
        {
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
                _Preco.Text = dr["preco"].ToString();
                Models.IDManagment.fkMarca_Modelo = dr["fk_Marca_Modelo_ID"].ToString();
            }
            con.Close();
        }

        public static void EditMachine(string _ID, string _Cor, string _Dimensoes, string _Preco)
        {
            SqlConnection con = new SqlConnection(Models.Utils.conString);
            con.Open();
            string query = "UPDATE Maquinas SET " +
                "cor=@cor," +
                "dimensoes=@dimensoes," +
                "preco=@preco " +
                " where id=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", _ID);
            cmd.Parameters.AddWithValue("@cor", _Cor);
            cmd.Parameters.AddWithValue("@dimensoes", _Dimensoes);
            cmd.Parameters.AddWithValue("@preco", _Preco);

            cmd.ExecuteScalar();
            MessageBox.Show("Registo editado.", "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        public static void LoadInfo(DataGridView _Datagridview)
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
                                "join Modelo as modl on modl.ID = marModl.fk_Modelo_ID";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                bs.DataSource = dt;
                _Datagridview.DataSource = bs;
                con.Close();
                Models.IDManagment.IdMaquina = "";
            }
        }

        public static byte[] ConvertImageToBytes(Image _img)
        {
            using(MemoryStream ms=new MemoryStream())
            {
                _img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        public static void UploadImage(PictureBox _Imagem)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter= "Image files(*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg", Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _Imagem.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

    }
}
