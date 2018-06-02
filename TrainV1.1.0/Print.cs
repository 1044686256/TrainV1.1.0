using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrainV1._1._0
{
    public partial class Print : Form
    {
        private AccessHelper achelp;
        public Print()
        {
            InitializeComponent();
        }

        private void databind1(string sqlstr)
        {
            DataTable dt = new DataTable();
            dt = achelp.GetDataTableFromDB(sqlstr);
            DataGridView1.DataSource = dt;
        }

        private void toolStripBakInit_Click(object sender, EventArgs e)
        {
            //if (DataGridView1.SelectedRows.Count < 1 || DataGridView1.SelectedRows[0].Cells[1].Value == null)
            //{
            //    MessageBox.Show("没有选中行。", "M营销");
            //    return;
            //}
            ////f3.Owner = this;
            //DataTable dt = new DataTable();
            //object oid = DataGridView1.SelectedRows[0].Cells[0].Value;
            //string sql = "select * from ycyx where ID=" + oid;
            //dt = achelp.GetDataTableFromDB(sql);
            //f3 = new Form3();
            //f3.id = int.Parse(oid.ToString());
            ////f3.id = 2;
            //f3.Text1 = dt.Rows[0][1].ToString();
            //f3.Text2 = dt.Rows[0][2].ToString();
            //f3.Text3 = dt.Rows[0][3].ToString();
            //f3.Text4 = dt.Rows[0][4].ToString();
            //f3.Text5 = dt.Rows[0][5].ToString();
            //f3.Text6 = dt.Rows[0][6].ToString();

            //f3.ShowDialog();

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            upDateDataGridView();
            achelp = new AccessHelper();
            if (cbbxMode.Text == "")
            {
                MessageBox.Show("Please select the query mode ");
                return;
            }
            else
            {
                string strCbxCondition = "";
                if (cbbxMode.Text == "Dates")
                {
                    strCbxCondition = "\"" + cbxCondition.Text + "\"";
                    //strSelectSql = "SELECT * FROM DeviceMsg where (" + cbbxMode.Text + "=" + cbxCondition.Text + ")";
                }
                else
                {
                    strCbxCondition = "'" + cbxCondition.Text + "'";
                }
                string strSelectSql = "SELECT IpAddress ,DeviceNum,Dates,Times,OrderNum,CarriageNum,ArtNo,SetWeight,LoadedWeight,TotalAmount FROM DeviceMsg where (" + cbbxMode.Text + "=" + strCbxCondition + ")";
                DataTable dt = new System.Data.DataTable();
                dt = achelp.GetDataTableFromDB(strSelectSql);
                DataGridView1.DataSource = dt;

                DataGridView1.Columns[DataGridView1.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }

        }

        private void upDateDataGridView()
        {
            CheckForIllegalCrossThreadCalls = false;
            achelp = new AccessHelper();
            DataTable dt = new DataTable();
            string strSelectSql = "SELECT IpAddress ,DeviceNum,Dates,Times,OrderNum,CarriageNum,ArtNo,SetWeight,LoadedWeight,TotalAmount from DeviceMsg ";
            dt = achelp.GetDataTableFromDB(strSelectSql);
            DataGridView1.DataSource = dt;//SetDGVSourceFunction(ds); // ds;
           // DataGridView1.DataMember = "dt";
            DataGridView1.Columns[DataGridView1.Columns.Count - 1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            DataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cbbxMode_Click(object sender, EventArgs e)
        {

        }

        private void cbbxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            upDateDataGridView();
            cbxCondition.Items.Clear();
            List<string> cbbx = new List<string>();
            //progressBarSelect.Show();
            try
            {
                switch (cbbxMode.Text)
                {
                    case "Dates":
                        //cbxCondition.Items.Clear();
                        foreach (DataGridViewRow dr in DataGridView1.Rows)
                        {
                            try
                            {
                                cbbx.Add(dr.Cells[cbbxMode.Text].Value.ToString());
                                foreach (var data in cbbx)
                                {
                                    cbxCondition.Items.Add(data);
                                }
                                RemoveRepeatItem(cbxCondition);
                                //for (int i = 0; i < cbbx.Count; i++)
                                //{
                                //    //cbxCondition.Items.Add(ipList[i].Trim());
                                //    //listBox1.Text += ipList[i].Trim();//cbxIpList.Items.Add(ipList[i]);
                                //}
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message.ToString(), "Error!!!");
                            }
                            finally
                            {
                                cbbx.Clear();
                            }

                        }
                        break;
                    case "OrderNum":
                        //cbxCondition.Items.Clear();
                        foreach (DataGridViewRow dr in DataGridView1.Rows)
                        {
                            try
                            {
                                cbbx.Add(dr.Cells[cbbxMode.Text].Value.ToString());
                                foreach (var data in cbbx)
                                {
                                    cbxCondition.Items.Add(data);
                                }
                                RemoveRepeatItem(cbxCondition);
                                //for (int i = 0; i < cbbx.Count; i++)
                                //{
                                //    //cbxCondition.Items.Add(ipList[i].Trim());
                                //    //listBox1.Text += ipList[i].Trim();//cbxIpList.Items.Add(ipList[i]);
                                //}
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message.ToString(), "Error!!!");
                            }
                            finally
                            {
                                cbbx.Clear();
                            }

                        }
                        break;
                    case "CarriageNum":
                        //cbxCondition.Items.Clear();
                        foreach (DataGridViewRow dr in DataGridView1.Rows)
                        {
                            try
                            {
                                cbbx.Add(dr.Cells[cbbxMode.Text].Value.ToString());
                                foreach (var data in cbbx)
                                {
                                    cbxCondition.Items.Add(data);
                                }
                                RemoveRepeatItem(cbxCondition);
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message.ToString(), "Error!!!");
                            }
                            finally
                            {
                                cbbx.Clear();
                            }

                        }
                        break;
                    case "ArtNo":
                        //cbxCondition.Items.Clear();
                        foreach (DataGridViewRow dr in DataGridView1.Rows)
                        {
                            try
                            {
                                cbbx.Add(dr.Cells[cbbxMode.Text].Value.ToString());
                                foreach (var data in cbbx)
                                {
                                    cbxCondition.Items.Add(data);
                                }
                                RemoveRepeatItem(cbxCondition);
                                //for (int i = 0; i < cbbx.Count; i++)
                                //{
                                //    //cbxCondition.Items.Add(ipList[i].Trim());
                                //    //listBox1.Text += ipList[i].Trim();//cbxIpList.Items.Add(ipList[i]);
                                //}
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message.ToString(), "Error!!!");
                            }
                            finally
                            {
                                cbbx.Clear();
                            }

                        }
                        break;
                    case "DeviceNum":
                        //cbxCondition.Items.Clear();
                        foreach (DataGridViewRow dr in DataGridView1.Rows)
                        {
                            try
                            {
                                cbbx.Add(dr.Cells[cbbxMode.Text].Value.ToString());
                                foreach (var data in cbbx)
                                {
                                    cbxCondition.Items.Add(data);
                                }
                                RemoveRepeatItem(cbxCondition);
                            }
                            catch (Exception err)
                            {
                                MessageBox.Show(err.Message.ToString(), "Error!!!");
                            }
                            finally
                            {
                                cbbx.Clear();
                            }

                        }
                        break;
                    default:
                        MessageBox.Show("Exception", "Error");
                        break;
                }

            }
            catch
            {

            }

            finally
            {
                cbbx.Clear();
            }
        }

        /// <summary>
        /// 删除Combobox重复的值
        /// </summary>
        /// <param name="cbb"></param>
        private void RemoveRepeatItem(ToolStripComboBox cbb)
        {
            List<string> list = new List<string>();
            foreach (string s in cbb.Items)
            {
                if (!list.Contains(s))
                {
                    list.Add(s);
                }
            }
            cbb.Items.Clear();
            foreach (string s in list)
            {
                cbb.Items.Add(s);
                // cbb.Items.Add(s.Substring(0, s.Length - 7));
            }
        }
    }
}
