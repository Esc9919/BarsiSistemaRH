using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;

namespace Barsi.Controlador
{
    public class PdfService
    {
        public void GerarPdfFolhaPagamento(int idFuncionario, DateTime inicioFolha, DateTime finalFolha)
        {

            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

            string pdfPath = Path.Combine(downloadsPath, $"Holerite_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");

            string connectionString = "Server=localhost;Database=BARSI;User Id=sa;Password=Admin2022;Trusted_Connection=true;TrustServerCertificate=true;";
            string query = "SELECT * FROM FolhaDePagamento WHERE FuncionarioID = @IdFuncionario ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IdFuncionario", idFuncionario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        
                        CriarPdfComDados(reader, pdfPath);
                    }
                }
            }
        }

        private void CriarPdfComDados(SqlDataReader reader, string pdfPath)
        {
            
            Document doc = new Document(PageSize.A4);

            
            using (FileStream fs = new FileStream(pdfPath, FileMode.Create))
            {
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                
                Paragraph title = new Paragraph("HOLERITE", new Font(Font.FontFamily.HELVETICA, 16, Font.BOLD, BaseColor.BLACK));
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                
                string imagePath = Path.Combine("C:\\Imagem", "Barsi.JPEG");
                Image img = Image.GetInstance(imagePath);
                img.ScaleAbsolute(100f, 100f); 
                img.SetAbsolutePosition(doc.PageSize.Width - 100f, doc.PageSize.Height - 100f); 
                doc.Add(img);

                doc.Add(Chunk.NEWLINE);

                
                while (reader.Read())
                {
                    
                    string funcionarioID = reader["FuncionarioID"].ToString();
                    string nome = reader["Nome"].ToString();
                    string salarioBase = reader["SalarioBase"].ToString();
                    string horasTrabalhadas = reader["HorasTrabalhadas"].ToString();
                    string horasExtras = reader["HorasExtras"].ToString();
                    string tempoExatoTrabalhado = reader["TempoExatoTrabalhado"].ToString();
                    string tempoExtraExatoTrabalhado = reader["TempoExtraExatoTrabalhado"].ToString();
                    string totalSalario = reader["TotalSalario"].ToString();
                    string iNSS = reader["INSS"].ToString();
                    string iRPF = reader["IRPF"].ToString();
                    string salarioLiquido = reader["SalarioLiquido"].ToString();


                    doc.Add(new Paragraph($"Nome: {nome}"));
                    doc.Add(new Paragraph($"ID do Colaborador: {funcionarioID}"));

                    doc.Add(Chunk.NEWLINE);


                    PdfPTable table = new PdfPTable(2); 
                    table.AddCell("Salário Base:");
                    table.AddCell(salarioBase);

                    table.AddCell("Horas Trabalhadas:");
                    table.AddCell(horasTrabalhadas);

                    table.AddCell("Horas Extras:");
                    table.AddCell(horasExtras);

                    table.AddCell("Tempo Trabalhado (min):");
                    table.AddCell(tempoExatoTrabalhado);

                    table.AddCell("Tempo Extra Trabalhado (min):");
                    table.AddCell(tempoExtraExatoTrabalhado);

                    table.AddCell("Total Salário:");
                    table.AddCell(totalSalario);

                    table.AddCell("Desconto de INSS:");
                    table.AddCell(iNSS);

                    table.AddCell("Desconto de IRPF:");
                    table.AddCell(iRPF);

                    table.AddCell("Salário Líquido:");
                    table.AddCell(salarioLiquido);

                    doc.Add(table);

                    doc.Add(Chunk.NEWLINE);


                    img.SetAbsolutePosition(doc.PageSize.Width - 100f, doc.PageSize.Height - 100f);
                    doc.Add(img);

                    doc.NewPage();
                }

                doc.Close();
            }
        }



    }
}
