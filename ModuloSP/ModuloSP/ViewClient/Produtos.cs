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
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }
        string ye;

        private void PDF()
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.FileName = "Proposta" + Models.IDManagment.IdSimulacao;
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

                    logo.ScaleAbsolute(140f, 60f);

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

                    cell1 = new PdfPCell(new Phrase("Nome: " + Models.CurrentUser.username , Segoe));
                    cell2 = new PdfPCell(new Phrase("Email: " + Models.CurrentUser.email , Segoe));
                    cell5 = new PdfPCell(new Phrase("Nº Ocorrência: " + Models.IDManagment.IdSimulacao, Segoe));

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

                    //Maquina e addons
                    PdfPTable table4 = new PdfPTable(1);

                    SqlConnection con =
                    new SqlConnection(Models.Utils.conString);
                    con.Open();
                    string query = "select Marca.Nome as marca, Modelo.Nome as modelo, Maquinas.Dimensoes as dimen, Maquinas.Cor as corMa, Produto_Imagem as img, Maquinas.Preco as prec, Marca_Modelo.ID as MarMod " +
                                   "from Maquinas " +
                                   "join Marca_Modelo  on Marca_Modelo.ID = Maquinas.fk_Marca_Modelo_ID " +
                                   "join Marca  on Marca.ID = Marca_Modelo.fk_Marca_ID " +
                                   "join Modelo on Modelo.ID = Marca_Modelo.fk_Modelo_ID " +
                                   "join Equipamentos on Equipamentos.fk_Maquinas_ID = Maquinas.ID " +
                                   "join AddOns_Equip on AddOns_Equip.fk_Equipamentos_ID = Equipamentos.ID " +
                                   "join Modelo_AddOns on Modelo_AddOns.ID = AddOns_Equip.fk_Modelo_AddOns_ID " +
                                   "join AddOns on AddOns.ID = Modelo_AddOns.fk_AddOns_ID " +
                                   "where Equipamentos.fk_Simulacoes_ID = '" + Models.IDManagment.IdSimulacao + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        ProductFilters.PrecoAddMaq(dr["MarMod"].ToString());

                        cell1 = new PdfPCell(new Phrase("Impressora " + dr["marca"].ToString() + " " + dr["modelo"].ToString() + " - " + dr["dimen"].ToString() + " - " + dr["corMa"].ToString(), Segoe2));
                        cell2 = new PdfPCell(new Phrase("Addon1", Segoe));
                        cell3 = new PdfPCell(new Phrase("Addon2", Segoe));
                        cell4 = new PdfPCell(new Phrase("Addon3", Segoe));
                        cell5 = new PdfPCell(new Phrase("Addon4", Segoe));

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

                        table4.AddCell(cell1);
                        table4.AddCell(cell2);
                        table4.AddCell(cell3);
                        table4.AddCell(cell4);
                        table4.AddCell(cell5);
                        //table4.SpacingBefore = 30;

                        //Imagem e preço

                        PdfPTable table5 = new PdfPTable(1);

                        byte[] data = dr["img"].ToString().Length > 0 ? (byte[])(dr["img"]) : Maquinas.FunctionsMaq.ConvertImageToBytes(Properties.Resources.editcolu);
                        MemoryStream mem = new MemoryStream(data);

                        iTextSharp.text.Image maq = iTextSharp.text.Image.GetInstance(data);

                        maq.ScaleToFit(80, 80);

                        cell1 = new PdfPCell(maq);

                        cell2 = new PdfPCell(new Phrase("Preço produto: " + ProductFilters.PrecoMaquinaAddOn + "€", Segoe));

                        cell1.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                        cell2.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

                        cell1.Border = iTextSharp.text.Rectangle.NO_BORDER;
                        cell2.Border = iTextSharp.text.Rectangle.NO_BORDER;

                        table5.AddCell(cell1);
                        table5.AddCell(cell2);

                        //table5.SpacingBefore = 30;

                        //tabela1 + tabela2
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

                        doc.Add(par);
                    
                       
                    }
                    con.Close();
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


        private void Produtos_Load(object sender, EventArgs e)
        {
            Maquinas.FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
            ProductFilters.CmbOrderItems(cmbOrder);
            ProductFilters.CmbColorItems(cmbColor);
            ProductFilters.CmbInsertM(cmbMarca);

           
        }

        private void cmbOrder_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbOrder.Text, cmbColor.Text, cmbMarca.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void cmbColor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbColor.Text, cmbMarca.Text, cmbOrder.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void cmbMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProductFilters.OverlayFilter(dataGridView1, cmbMarca.Text, cmbColor.Text, cmbOrder.Text, cmbOrder.Text, cmbColor.Text, cmbMarca.Text);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cmbColor.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            Maquinas.FunctionsMaq.LoadInfo(dataGridView1);
            Models.FunctionsGeneral.EditDataGrid(dataGridView1);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == typeof(ViewClient.ProdutoShow))
                {
                    frm.Activate();
                    return;
                }
            }

            var userList = new ViewClient.ProdutoShow();

            Models.Utils._form.mudaform(userList);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewClient.ProductFilters.ID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void Produtos_Activated(object sender, EventArgs e)
        {
            ProductFilters.MaquinasInSimulacao(Models.IDManagment.IdSimulacao);
            toolStripStatusLabelImpressoras.Text = ProductFilters.NumImpressoras;
            if (Models.IDManagment.IdSimulacao != "")
            {
                toolStripStatusLabel2.Visible = true;
            }
        }

        private void Produtos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Models.IDManagment.IdSimulacao == "")
            {

            }
            else
            {

                if (MessageBox.Show("Terminar Simulação ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    PDF();
                    Models.IDManagment.IdSimulacao = "";
                    ProductFilters.NumImpressoras = "0";
                  
                }
            }
        }


        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            if (Models.IDManagment.IdSimulacao == "")
            {

            }
            else
            {

                if (MessageBox.Show("Terminar Simulação ?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    PDF();
                    Models.IDManagment.IdSimulacao = "";
                    ProductFilters.NumImpressoras = "0";
                    
                   
                    this.Close();

                }
            }
           
        }
    }
}
