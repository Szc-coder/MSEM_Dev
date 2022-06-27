using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spire.Xls;

namespace MSEM_Dev.Uitls
{
    public static class dataGirdToExcel
    {
        public static void ExportToExcel(DataGridView dg, string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.DefaultExt = ".xls";
            saveFileDialog.Filter = "Excel文件|*.xls";
            saveFileDialog.FileName = fileName;
            saveFileDialog.ShowDialog();
            string saveFileName = saveFileDialog.FileName;
            if (saveFileName.IndexOf(":") < 0)
            {
                return;
            }

            Spire.Xls.Workbook wb = new Spire.Xls.Workbook();
            Spire.Xls.Worksheet ws = wb.Worksheets[0];



            for (int i = 0; i < dg.ColumnCount; i++)
            {
                ws.Range[1, i+1].Text = dg.Columns[i].HeaderCell.Value.ToString();
            }

            for (int i = 0; i < dg.RowCount; i++)
            {
                for (int j = 0; j < dg.ColumnCount; j++)
                {
                    ws.Range[i + 2, j + 1].Text = dg.Rows[i].Cells[j].Value.ToString();
                }
                System.Windows.Forms.Application.DoEvents();
            }


            if (saveFileName != "")
            {
                try
                {
                    wb.SaveToFile(saveFileName);
                    MessageBox.Show("保存成功");
                }
                catch (Exception e)
                {
                    MessageBox.Show("导出错误");
                }
            }
            GC.Collect();
        } 

    }
}
