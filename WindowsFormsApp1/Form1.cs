using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dataSelect_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = false;            //파일 선택dfdfdfd
            dialog.Filters.Add(new CommonFileDialogFilter("Excel", "*.xlsx"));
            //dialog.Filters.Add(new CommonFileDialogFilter("CSV", "*.csv"));
	//ffff

            if (dialog.ShowDialog() == CommonFileDialogResult.Cancel)
            {
                return;
            }

            string dic = dialog.FileName;
            tb_dataPath.Text = dic;

            Excel.Application excelApp = null;
            Excel.Workbook workBook = null;
            Excel.Worksheet workSheet = null;

            try
            {
                excelApp = new Excel.Application();                             // 엑셀 어플리케이션 생성
                workBook = excelApp.Workbooks.Open(dic);                       // 워크북 열기
                workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet; // 엑셀 첫번째 워크시트 가져오기

                Excel.Range range = workSheet.UsedRange;
                object[,] data = range.Value2;

                //object[,] data = new object[100, 100];// range.Value2;
                int totalCont = range.Rows.Count;
                int columnCount = range.Columns.Count;


                dataGridView.Rows.Clear();

                //3번째 줄부터 데이터
                for (int row = 1; row <= totalCont; row++) // 가져온 행 만큼 반복
                {
                    if (row == 1)
                    {
                        for (int i = 1; i < columnCount + 1; i++)
                        {
                            DataGridViewTextBoxColumn dgvc = new DataGridViewTextBoxColumn();
                            dgvc.Name = data[row, i].ToString();
                            dgvc.HeaderText = data[row, i].ToString();
                            dgvc.Width = 150;
                            dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;

                            dataGridView.Columns.Add(dgvc);
                        }

                    }
                    else
                    {
                        object[] param_data = new object[columnCount];

                        for (int i = 1; i < columnCount + 1; i++)
                        {
                            param_data[i - 1] = data[row, i];
                        }

                        dataGridView.Rows.Add(param_data);
                    }

                }


                workBook.Close(true);   // 워크북 닫기
                excelApp.Quit();        // 엑셀 어플리케이션 종료
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ReleaseObject(workSheet);
                ReleaseObject(workBook);
                ReleaseObject(excelApp);
            }
        }
        /// <summary>
        /// 액셀 객체 해제 메소드
        /// </summary>
        /// <param name="obj"></param>
        private void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);  // 액셀 객체 해제
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();   // 가비지 수집
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
