using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloSP.ViewClient
{
    public partial class ListSimulacao : Form
    {
        public ListSimulacao()
        {
            InitializeComponent();
        }
        private void PDF()
        {

            List<string> listEquip = new List<string>(ProductFilters.EquipamentosList(ProductFilters.IDSimulacao));
            ProductFilters.UserPDF(ProductFilters.IDSimulacao);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.FileName = "Proposta" + ProductFilters.IDSimulacao;
            saveFileDialog1.Filter = "txt files (*.PDF)|*.pdf|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Document doc = new Document(PageSize.A4);
                Font Segoe = FontFactory.GetFont("Segoe UI", 8, BaseColor.BLACK);
                Font Segoe2 = FontFactory.GetFont("Segoe UI", 10, BaseColor.BLACK);
                Font Segoe3 = FontFactory.GetFont("Segoe UI", 14, BaseColor.BLACK);
                BaseFont arial = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                iTextSharp.text.Font f_15_bold = new iTextSharp.text.Font(arial, 13, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font f_12_normal = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font f_12_precoprod = new iTextSharp.text.Font(arial, 12, iTextSharp.text.Font.BOLD);
                Chunk linebreak = new Chunk(new LineSeparator(1f, 100f, BaseColor.DARK_GRAY, Element.ALIGN_CENTER, -1));
                Paragraph par = new Paragraph("");

                try
                {
                    var wri = PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.Create));
                    wri.PageEvent = new Models.PDF();
                    doc.Open();

                    //Logo
                    string imageURL = "img/logo.png";

                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(imageURL);

                    logo.ScaleToFit(140f, 120f);

                    logo.ScaleAbsolute(160f, 60f);

                    logo.Alignment = Element.ALIGN_LEFT;

                    doc.Add(logo);

                    //Informações empresa
                    PdfPTable table1 = new PdfPTable(1);
                    float[] width = new float[] { 40f, 60f };

                    PdfPCell cell1 = new PdfPCell(new Phrase("IRAONEBIT - SOLUÇÕES INFORMÁTICAS, LDA", Segoe));
                    PdfPCell cell2 = new PdfPCell(new Phrase("\nRua Povoa da Carvalha, EDF. Lusabit Center", Segoe));
                    PdfPCell cell3 = new PdfPCell(new Phrase("3750 - 720 Recardães | NIF 510 556 353", Segoe));
                    PdfPCell cell4 = new PdfPCell(new Phrase("Email: comercial@forbrand.pt | www.forbrand.pt", Segoe));
                    PdfPCell cell5 = new PdfPCell(new Phrase("", Segoe));

                    cell1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell3.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell4.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                    cell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cell4.Border = iTextSharp.text.Rectangle.NO_BORDER;

                    table1.WidthPercentage = 45;
                    table1.HorizontalAlignment = Element.ALIGN_LEFT;
                    table1.AddCell(cell1);
                    table1.AddCell(cell2);
                    table1.AddCell(cell3);
                    table1.AddCell(cell4);


                    table1.SpacingBefore = 0;
                    //doc.Add(table1);

                    //Informações cliente;
                    PdfPTable table2 = new PdfPTable(1);

                    cell1 = new PdfPCell(new Phrase("Nome: " + ProductFilters.Nome, Segoe));
                    cell2 = new PdfPCell(new Phrase("Email: " + ProductFilters.Email, Segoe));
                    cell5 = new PdfPCell(new Phrase("Nº Ocorrência: " + ProductFilters.IDSimulacao, Segoe));

                    cell1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell3.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell4.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell5.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                    cell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cell3.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cell4.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    cell5.Border = iTextSharp.text.Rectangle.NO_BORDER;

                    table2.AddCell(cell1);
                    table2.AddCell(cell2);
                    table2.AddCell(cell5);

                    table1.SpacingAfter = 20;

                    //PdfPTable table2 = new PdfPTable(1);
                    table2.SpacingBefore = 0;
                    table2.HorizontalAlignment = Element.ALIGN_RIGHT;
                    table2.WidthPercentage = 40;
                    //doc.Add(table2);

                    //tabela1 + tabela2
                    PdfPTable table3 = new PdfPTable(2);
                    PdfPCell _cellAux1 = new PdfPCell(table1);
                    PdfPCell _cellAux2 = new PdfPCell(table2);
                    _cellAux1.BorderWidth = 0;
                    _cellAux1.Border = Rectangle.NO_BORDER;
                    _cellAux2.Border = Rectangle.NO_BORDER;
                    _cellAux2.PaddingLeft = 120;
                    table3.AddCell(_cellAux1);
                    table3.AddCell(_cellAux2);
                    table3.SpacingAfter = 15;
                    table3.WidthPercentage = 100.0f;

                    doc.Add(table3);

                    //Titulo
                    Paragraph title = new Paragraph(new Phrase("Proposta", Segoe3));
                    title.SpacingBefore = 15;
                    title.Alignment = Element.ALIGN_CENTER;

                    doc.Add(title);

                    doc.Add(linebreak);


                    for (int i = 0; i < listEquip.Count; i++)
                    {
                        SqlConnection con =
                        new SqlConnection(Models.Utils.conString);
                        con.Open();
                        string query = @"select Marca.Nome as marca, Modelo.Nome as modelo, Maquinas.Dimensoes as dimen, Maquinas.Cor as corMa, Produto_Imagem as img, Marca_Modelo.ID as MarMod 
                                        from Maquinas
                                        join Marca_Modelo  on Marca_Modelo.ID = Maquinas.fk_Marca_Modelo_ID
                                        join Marca  on Marca.ID = Marca_Modelo.fk_Marca_ID
                                        join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID
                                        join Equipamentos on Equipamentos.fk_Maquinas_ID = Maquinas.ID
                                        where Equipamentos.ID = '" + listEquip[i] + "'";
                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {

                            ProductFilters.PrecoAddMaq(listEquip[i], ProductFilters.IDSimulacao);
                            ProductFilters.PrecoTotalSimulacao(ProductFilters.IDSimulacao);

                            //Maquina 
                            PdfPTable table4 = new PdfPTable(1);
                            cell1 = new PdfPCell(new Phrase("Impressora " + dr["marca"].ToString() + " " + dr["modelo"].ToString() + " - " + dr["dimen"].ToString() + " - " + dr["corMa"].ToString(), Segoe2));


                            cell1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                            cell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            table4.AddCell(cell1);

                            //AddOns
                            SqlConnection con2 =
                            new SqlConnection(Models.Utils.conString);
                            con2.Open();
                            string query2 = @"Select AddOns.Descricao as dec, AddOns_Equip.Quantidade as qtd
                                                    from AddOns_Equip
                                                    JOIN Modelo_AddOns on Modelo_AddOns.ID = AddOns_Equip.fk_Modelo_AddOns_ID
                                                    JOIN AddOns on AddOns.ID = Modelo_AddOns.fk_AddOns_ID
                                                    where AddOns_Equip.fk_Equipamentos_ID = '" + listEquip[i] + "'";
                            SqlCommand dmc = new SqlCommand(query2, con2);
                            SqlDataReader rd = dmc.ExecuteReader();
                            while (rd.Read())
                            {
                                cell2 = new PdfPCell(new Phrase(rd["dec"].ToString() + "\n" + "Quantidade: " + rd["qtd"].ToString(), Segoe));
                                //cell3 = new PdfPCell(new Phrase("Quantidade: " + rd["qtd"].ToString(), Segoe));
                                cell2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                                cell2.Border = iTextSharp.text.Rectangle.NO_BORDER;
                                table4.AddCell(cell2);
                            }
                            con2.Close();



                            //table4.AddCell(cell3);
                            //table4.SpacingBefore = 30;

                            //Imagem e preço

                            PdfPTable table5 = new PdfPTable(1);

                            byte[] data = dr["img"].ToString().Length > 0 ? (byte[])(dr["img"]) : Maquinas.FunctionsMaq.ConvertImageToBytes(Properties.Resources.editcolu);
                            MemoryStream mem = new MemoryStream(data);

                            iTextSharp.text.Image maq = iTextSharp.text.Image.GetInstance(data);

                            maq.ScaleToFit(80, 80);

                            cell1 = new PdfPCell(maq);

                            cell2 = new PdfPCell(new Phrase("Preço produto: " + (ProductFilters.PrecoMaquina + ProductFilters.PrecoMaquinaAddOn).ToString() + "€", Segoe));

                            cell1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                            cell2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                            cell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                            cell2.Border = iTextSharp.text.Rectangle.NO_BORDER;

                            table5.AddCell(cell1);
                            table5.AddCell(cell2);

                            //table5.SpacingBefore = 30;

                            //tabela4 + tabela5
                            PdfPTable table6 = new PdfPTable(2);
                            PdfPCell _cellAux3 = new PdfPCell(table4);
                            PdfPCell _cellAux4 = new PdfPCell(table5);
                            _cellAux3.Border = Rectangle.NO_BORDER;
                            _cellAux4.Border = Rectangle.NO_BORDER;
                            _cellAux4.PaddingLeft = 120;
                            table6.AddCell(_cellAux3);
                            table6.AddCell(_cellAux4);
                            table6.WidthPercentage = 100.0f;


                            doc.Add(table6);

                            doc.Add(par);

                            doc.Add(linebreak);



                        }
                        con.Close();
                    }

                    wri.PageEvent = new Models.PDF();

                    doc.Close();

                    Process.Start(saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
        }

        private void Simulacao_Load(object sender, EventArgs e)
        {
            ProductFilters.ShowSimulacao(dataGridView1, Models.CurrentUser.IDUser);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Models.IDManagment.IdSimulacao = "";

            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewClient.Produtos))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new ViewClient.Produtos();

            Models.Utils._form.mudaform(userList);
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (ProductFilters.IDSimulacao == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(ViewClient.ViewSimulasoes))
                    {
                        frm.Activate();
                        return;
                    }
                }
                var userList = new ViewClient.ViewSimulasoes();

                Models.Utils._form.mudaform(userList);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductFilters.IDSimulacao = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void ListSimulacao_Activated(object sender, EventArgs e)
        {
            ProductFilters.ShowSimulacao(dataGridView1, Models.CurrentUser.IDUser);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            
            toolStripStatusLabelImpressoras.Text = dataGridView1.Rows.Count.ToString();
        }

        private void toolStripButtonPDF_Click(object sender, EventArgs e)
        {
            if (ProductFilters.IDSimulacao == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PDF();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductFilters.IDSimulacao == "")
            {
                MessageBox.Show("Selecione um registo primeiro", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.GetType() == typeof(ViewClient.ViewSimulasoes))
                    {
                        frm.Activate();
                        return;
                    }
                }
                var userList = new ViewClient.ViewSimulasoes();

                Models.Utils._form.mudaform(userList);
            }
        }
    }
}
