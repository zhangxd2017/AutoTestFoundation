using AutoTestFoundation.Manager;
using AutoTestFoundation.Model;
using AutoTestFoundation.Util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AutoTestFoundation.UI
{
    public partial class SettingForm : Form
    {

        private string targetDataBase = null;
        private List<Item> items = new List<Item>();

        public SettingForm()
        {
            InitializeComponent();
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            string appConfigPath = PathUtil.GetAppConfig();
            if (File.Exists(appConfigPath))
            {
                string applicationStr = File.ReadAllText(appConfigPath);
                AppConfig application = JsonConvert.DeserializeObject<AppConfig>(applicationStr);
                if (application != null && application.DataBaseName != null)
                {
                    targetDataBase = application.DataBaseName;
                    ItemManager.GetItemManager().InitWithConfig(PathUtil.GetConfigPath() + targetDataBase);
                    InitDataGrid();
                }
            }
            GetAllDataBase();
        }

        #region 控件事件
        private void AddButton_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.add_press;
        }

        private void AddButton_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.add;
        }

        private void RemoveButton_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.delete_press;
        }

        private void RemoveButton_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.delete;
        }

        private void UpButton_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.up_press;
        }

        private void UpButton_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.up;
        }

        private void DownButton_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.down_press;
        }

        private void DownButton_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picture = (PictureBox)sender;
            picture.Image = Properties.Resources.down;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (SettingDataGridView.SelectedCells.Count > 1)    //添加到选中一行的前面
            {
                int position = SettingDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                DataGridViewTextBoxCell indexCell = new DataGridViewTextBoxCell();
                indexCell.Value = position + 1;
                dataGridViewRow.Cells.Add(indexCell);
                for (int i = 0; i < SettingDataGridView.Rows.Count; i++)
                {
                    if (i >= position)
                    {
                        SettingDataGridView[ColumnIndex.Index, i].Value = i + 2;
                    }
                }
                SettingDataGridView.Rows.Insert(SettingDataGridView.SelectedCells[0].RowIndex, dataGridViewRow);
                SettingDataGridView.ClearSelection();
                SelectRow(position);
            }
            //最后一行添加
            else
            {
                int position = SettingDataGridView.Rows.Count;
                DataGridViewRow dataGridViewRow = new DataGridViewRow();
                DataGridViewTextBoxCell indexCell = new DataGridViewTextBoxCell();
                indexCell.Value = position + 1;
                dataGridViewRow.Cells.Add(indexCell);
                SettingDataGridView.Rows.Add(dataGridViewRow);
                SelectRow(position);
            }
            
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (SettingDataGridView.SelectedCells.Count > 1)
            {
                int position = SettingDataGridView.SelectedCells[0].RowIndex;
                for (int i = 0; i < SettingDataGridView.Rows.Count; i++)
                {
                    if (i >= position)
                    {
                        SettingDataGridView[ColumnIndex.Index, i].Value = i;
                    }
                }
                SettingDataGridView.Rows.RemoveAt(position);
                SettingDataGridView.ClearSelection();
                SelectRow(position);
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (SettingDataGridView.SelectedCells.Count > 1)
            {
                int position = SettingDataGridView.SelectedCells[0].RowIndex;
                ExChangeRowValue(position, position - 1);
                SettingDataGridView.ClearSelection();
                SelectRow(position - 1);
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (SettingDataGridView.SelectedCells.Count > 1)
            {
                int position = SettingDataGridView.SelectedCells[0].RowIndex;
                ExChangeRowValue(position, position + 1);
                SettingDataGridView.ClearSelection();
                SelectRow(position + 1);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SettingDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnExecute.Index)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = PathUtil.GetToolPath();
                openFileDialog.Title = "选择测试执行文件";
                openFileDialog.Filter = "可执行文件(*.bat)|*.bat";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    ((DataGridView)sender)[e.RowIndex, e.ColumnIndex].Value = openFileDialog.FileName;
                }
                else
                {
                    ((DataGridView)sender).CancelEdit();
                }
            }
            else if (e.ColumnIndex == ColumnParamerters.Index)
            {

            }
        }

        private void SettingDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnIndex.Index)
            {
                SelectRow(e.RowIndex);
            }
        }
        #endregion


        private void GetAllDataBase()
        {
            string[] dbs = Directory.GetFiles(PathUtil.GetConfigPath(), "*.db");
            for (int i = 0; i < dbs.Length; i++)
            {
                string filePath = dbs[i];
                string fileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
                if (!string.Empty.Equals(fileName))
                {
                    ConfigComboBox.Items.Add(fileName);
                    if (fileName.Equals(targetDataBase))
                    {
                        ConfigComboBox.SelectedItem = fileName;
                    }
                }
            }
        }

        private void InitDataGrid()
        {
            List<Item> tmpItems = ItemManager.GetItemManager().GetItems();
            if (tmpItems.Count > 0)
            {
                items.Clear();
                foreach (Item item in tmpItems)
                {
                    items.Add(item);
                    DataGridViewRow viewRow = new DataGridViewRow();
                    //序号
                    DataGridViewTextBoxCell indexCell = new DataGridViewTextBoxCell();
                    indexCell.Value = item.Index;
                    viewRow.Cells.Add(indexCell);
                    //名称
                    DataGridViewTextBoxCell nameCell = new DataGridViewTextBoxCell();
                    nameCell.Value = item.ItemName;
                    viewRow.Cells.Add(nameCell);
                    //可执行文件路径
                    DataGridViewTextBoxCell executeCell = new DataGridViewTextBoxCell();
                    executeCell.Value = item.ExecutablePath;
                    viewRow.Cells.Add(executeCell);
                    //参数
                    DataGridViewTextBoxCell paramsCell = new DataGridViewTextBoxCell();
                    paramsCell.Value = item.Parameters;
                    viewRow.Cells.Add(paramsCell);
                    //超时
                    DataGridViewTextBoxCell timeoutCell = new DataGridViewTextBoxCell();
                    timeoutCell.Value = item.TimeOut;
                    viewRow.Cells.Add(timeoutCell);
                    //重试
                    DataGridViewTextBoxCell repeatCell = new DataGridViewTextBoxCell();
                    repeatCell.Value = item.RepeatCount;
                    viewRow.Cells.Add(repeatCell);
                    //是否测试
                    DataGridViewCheckBoxCell needtestCell = new DataGridViewCheckBoxCell();
                    needtestCell.Value = item.NeedTest;
                    viewRow.Cells.Add(needtestCell);
                    SettingDataGridView.Rows.Add(viewRow);
                }
                SettingDataGridView.ClearSelection();
            }
        }

        private void SelectRow(int row)
        {
            if (SettingDataGridView.RowCount > 0)
            {
                if (row > SettingDataGridView.RowCount - 1)
                {
                    row = SettingDataGridView.RowCount - 1;
                }
                SettingDataGridView[ColumnIndex.Index, row].Selected = true;
                SettingDataGridView[ColumnName.Index, row].Selected = true;
                SettingDataGridView[ColumnExecute.Index, row].Selected = true;
                SettingDataGridView[ColumnParamerters.Index, row].Selected = true;
                SettingDataGridView[ColumnTimeOut.Index, row].Selected = true;
                SettingDataGridView[ColumnRepeatCount.Index, row].Selected = true;
                SettingDataGridView[ColumnNeedTest.Index, row].Selected = true;
            }
            else
            {
                SettingDataGridView.ClearSelection();
            }
        }

        private void ExChangeRowValue(int sourceRow, int destRow)
        {
            object name = SettingDataGridView[ColumnName.Index, sourceRow].Value;
            object excute = SettingDataGridView[ColumnExecute.Index, sourceRow].Value;
            object parameter = SettingDataGridView[ColumnParamerters.Index, sourceRow].Value;
            object timeout = SettingDataGridView[ColumnTimeOut.Index, sourceRow].Value;
            object repeat = SettingDataGridView[ColumnRepeatCount.Index, sourceRow].Value;
            object need = SettingDataGridView[ColumnNeedTest.Index, sourceRow].Value;

            SettingDataGridView[ColumnName.Index, sourceRow].Value = SettingDataGridView[ColumnName.Index, destRow].Value;
            SettingDataGridView[ColumnExecute.Index, sourceRow].Value = SettingDataGridView[ColumnExecute.Index, destRow].Value;
            SettingDataGridView[ColumnParamerters.Index, sourceRow].Value = SettingDataGridView[ColumnParamerters.Index, destRow].Value;
            SettingDataGridView[ColumnTimeOut.Index, sourceRow].Value = SettingDataGridView[ColumnTimeOut.Index, destRow].Value;
            SettingDataGridView[ColumnRepeatCount.Index, sourceRow].Value = SettingDataGridView[ColumnRepeatCount.Index, destRow].Value;
            SettingDataGridView[ColumnNeedTest.Index, sourceRow].Value = SettingDataGridView[ColumnNeedTest.Index, destRow].Value;

            SettingDataGridView[ColumnName.Index, destRow].Value = name;
            SettingDataGridView[ColumnExecute.Index, destRow].Value = excute;
            SettingDataGridView[ColumnParamerters.Index, destRow].Value = parameter;
            SettingDataGridView[ColumnTimeOut.Index, destRow].Value = timeout;
            SettingDataGridView[ColumnRepeatCount.Index, destRow].Value = repeat;
            SettingDataGridView[ColumnNeedTest.Index, destRow].Value = need;
        }
    }
}
