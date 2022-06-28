using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Configuration;

namespace MertDogan_202503033
{
    /// <summary>
    /// Database's backend
    /// </summary>

    class RegProcessClass
    {
        //
        //Variables and objects 
        //

        //Remote Server Connections String
        public static string conAdress = @"Data Source=SQL8003.site4now.net;Initial Catalog=db_a87ab7_202503033mert;User Id=db_a87ab7_202503033mert_admin;Password=Sylar3120";

        //Static Local Connection String
        //public static string conAdress = @"Data Source=CORVO;Initial Catalog=202503033;Integrated Security=True"; // hocam local hostunuzu yapın

        public static SqlConnection con;
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static SqlDataReader reader;
        public static DataSet ds;
        public static int UserID = 0;
        public static bool IsAdmin = false;
        public static bool itSend = false;
        static string hashedPassword;

        // Database Methods
        public static bool ConnectionCase()
        {
            using (con = new SqlConnection(conAdress))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return false;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return false;
                }
                finally { con.Close(); }
            }
        }
        static bool IsContains(RJControls.RJConpanents.RJComboBox cmBox, RJconpanents.RJtextBox txtBox) //IsContainsReg
        {
            try
            {
                con.Open();

                var sql = string.Format("IsContainsReg");

                SqlCommand cmdControl = new SqlCommand(sql, con);
                cmdControl.CommandType = CommandType.StoredProcedure;
                cmdControl.Parameters.Add("@RegNumberPhone", SqlDbType.NVarChar, 20).Value = cmBox.SelectedItem.ToString() + "-" + txtBox.Texts;
                SqlDataReader dr = cmdControl.ExecuteReader();

                if (dr.Read())
                    return false;
                else
                    return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { con.Close(); }
        }
        static bool IsContains(params RJconpanents.RJtextBox[] textBoxes)
        {
            try
            {
                con.Open();
                var sql = string.Format("IsContainsUser");
                SqlCommand cmdControl = new SqlCommand(sql, con);
                cmdControl.CommandType = CommandType.StoredProcedure;
                cmdControl.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = textBoxes[0].Texts;
                cmdControl.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 50).Value = textBoxes[1].Texts;
                SqlDataReader dr = cmdControl.ExecuteReader();

                if (dr.Read())
                    return false;
                else
                    return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { con.Close(); }
        } //IsContainsUser
        static bool IsContains(string phoneNumber, int userId)
        {
            try
            {
                con.Open();
                var sql = string.Format("SELECT RegNumberPhone FROM Tbl_Registry where RegNumberPhone='{0}' and UserID in({1})", phoneNumber, userId);
                SqlCommand cmdControl = new SqlCommand(sql, con);
                SqlDataReader dr = cmdControl.ExecuteReader();

                if (dr.Read())
                    return false;
                else
                    return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally { con.Close(); }
        } //IsContainsSendDirectory
        static void GetLastRegID()
        {
            con = new SqlConnection(conAdress);
            try
            {
                con.Open();
                var sql = string.Format("GetLastRegID");

                SqlCommand cmdGetLastRegID = new SqlCommand(sql, con);
                cmdGetLastRegID.CommandType = CommandType.StoredProcedure;
                cmdGetLastRegID.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                PhoneNumberAdd.LastID = Convert.ToInt32(cmdGetLastRegID.ExecuteScalar());
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }
        } //Every
        public static DataGridView GridFill(DataGridView dgv, string sqlSelectcom)
        {
            con = new SqlConnection(conAdress);
            da = new SqlDataAdapter(sqlSelectcom, conAdress);
            ds = new DataSet();

            try
            {
                con.Open();
                da.Fill(ds, sqlSelectcom);
                dgv.DataSource = ds.Tables[sqlSelectcom];
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }

            return dgv;
        }
        public static RJControls.RJConpanents.RJComboBox GridFillAllUser(RJControls.RJConpanents.RJComboBox comb, string sqlSelectcom)
        {
            con = new SqlConnection(conAdress);
            da = new SqlDataAdapter(sqlSelectcom, conAdress);
            ds = new DataSet();

            try
            {
                con.Open();
                da.Fill(ds, sqlSelectcom);
                comb.DataSource = ds.Tables[sqlSelectcom];
                comb.DisplayMember = "UserName";
                comb.Texts = "Kullanıcı Ara";

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }

            return comb;
        }
        public static void RegAdd(DataGridView dgv, Panel pnl, RJControls.RJConpanents.RJComboBox cmBox, params RJconpanents.RJtextBox[] textBoxes) //+
        {
            con = new SqlConnection(conAdress);
            string RegTypeTxt = default;

            if (IsContains(cmBox, textBoxes[3]))
            {
                try
                {
                    con.Open();

                    foreach (RadioButton item in pnl.Controls)
                        if (item.Checked)
                            RegTypeTxt = item.Text;

                    var sql = string.Format("RegAdd");

                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@RegName", SqlDbType.NVarChar, 20).Value = textBoxes[1].Texts;
                    cmd.Parameters.Add("@RegSurname", SqlDbType.NVarChar, 20).Value = textBoxes[2].Texts;
                    cmd.Parameters.Add("@RegNumberPhone", SqlDbType.NVarChar, 20).Value = (cmBox.SelectedItem.ToString() + "-" + textBoxes[3].Texts).Trim();
                    cmd.Parameters.Add("@RegType", SqlDbType.NVarChar, 10).Value = RegTypeTxt;
                    cmd.Parameters.Add("@RegImagePath", SqlDbType.NVarChar, 500).Value = PhoneNumberAdd.ImagePath.ToString();
                    cmd.Parameters.Add("@RegEmail", SqlDbType.NVarChar, 50).Value = textBoxes[4].Texts;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    cmd.ExecuteNonQuery(); // İstenilen soruguyu çalıştırmamıza yarıyor. 
                    GetLastRegID();
                    textBoxes[0].Texts = PhoneNumberAdd.LastID.ToString();
                    HomePage.DataGridUpdateList(dgv);


                    MessageBox.Show("Kayıt Rehebere Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally { con.Close(); }
            }
            else
            {
                MessageBox.Show((cmBox.SelectedItem.ToString() + "-" + textBoxes[3].Texts).Trim() + " Numaralı Kayıt Rehberde Mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void RegAdd(Form form, bool IsLoginToSign, DataGridView dgv, params RJconpanents.RJtextBox[] textBoxes) //+
        {
            con = new SqlConnection(conAdress);

            if (IsContains(textBoxes[0], textBoxes[2]))
            {
                try
                {
                    con.Open();

                    hashedPassword = SHA256(SHA256(Login.Password));

                    var sql = string.Format("UserAdd");

                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = textBoxes[0].Texts;
                    cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar, 64).Value = hashedPassword;
                    cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 50).Value = $"{ textBoxes[2].Texts}";
                    cmd.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = 0;
                    cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 15).Value = textBoxes[3].Texts;
                    cmd.Parameters.Add("@Surname", SqlDbType.NVarChar, 15).Value = textBoxes[4].Texts;
                    cmd.ExecuteNonQuery();

                    if (IsLoginToSign == false)
                        HomePage.DataGridUpdateList(dgv);

                    DialogResult result = MessageBox.Show("Kayıt işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (HomePage.admin == false && result == DialogResult.OK)
                    {
                        form.Close();
                        Login login = new Login();
                        login.Show();
                    }
                    else if (result == DialogResult.OK)
                    {
                        form.Close();
                    }

                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
                finally { con.Close(); }
            }
            else
            {
                MessageBox.Show("\"" + textBoxes[0].Texts + "\"" + " Kullanıcı adı veya \"" + textBoxes[2].Texts + "\" E-Mail hesabı daha önce alınmış .", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static void RegAddForSendCopy(DataGridView dgv, int userId) //userID gönderilmek istenen id
        {
            con = new SqlConnection(conAdress);

            try
            {
                for (int rows = 0; rows < dgv.Rows.Count; rows++)
                {
                    var _user = new DictionaryList();

                    //for (int col = 1; col < dgv.Rows[rows].Cells.Count; col++) // Canceled 
                    //{
                    _user.RegName = dgv.Rows[rows].Cells[1].Value.ToString();
                    _user.RegSurname = dgv.Rows[rows].Cells[2].Value.ToString();
                    _user.RegNumberPhone = dgv.Rows[rows].Cells[3].Value.ToString();
                    _user.RegType = dgv.Rows[rows].Cells[4].Value.ToString();
                    _user.RegImagePath = dgv.Rows[rows].Cells[5].Value.ToString();
                    _user.RegEmail = dgv.Rows[rows].Cells[6].Value.ToString();
                    _user.UserID = userId;

                    if (IsContains(_user.RegNumberPhone, _user.UserID))
                    {
                        try
                        {
                            con.Open();

                            var sql = string.Format("RegAddForSendCopy");

                            cmd = new SqlCommand(sql, con);
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.Add("@RegName", SqlDbType.NVarChar, 20).Value = _user.RegName;
                            cmd.Parameters.Add("@RegSurname", SqlDbType.NVarChar, 20).Value = _user.RegSurname;
                            cmd.Parameters.Add("@RegNumberPhone", SqlDbType.NVarChar, 20).Value = _user.RegNumberPhone;
                            cmd.Parameters.Add("@RegType", SqlDbType.NVarChar, 10).Value = _user.RegType;
                            cmd.Parameters.Add("@RegImagePath", SqlDbType.NVarChar, 500).Value = _user.RegImagePath;
                            cmd.Parameters.Add("@RegEmail", SqlDbType.NVarChar, 50).Value = _user.RegEmail;
                            cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = _user.UserID;
                            cmd.ExecuteNonQuery();

                        }
                        catch (InvalidOperationException ex)
                        {
                            MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw;
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            throw;
                        }
                        finally { con.Close(); }
                    }
                    //}
                }
                MessageBox.Show("Kayıt Gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static void RegUpdate(DataGridView dgv, Panel pnl, RJControls.RJConpanents.RJComboBox cmBox, params RJconpanents.RJtextBox[] textBoxes) //+
        {
            string RegTypeTxt = default;

            try
            {
                con.Open();

                foreach (RadioButton item in pnl.Controls)
                    if (item.Checked)
                        RegTypeTxt = item.Text;

                var sql = string.Format("RegUpdate");
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@RegName", SqlDbType.NVarChar, 20).Value = textBoxes[1].Texts;
                cmd.Parameters.Add("@RegSurname", SqlDbType.NVarChar, 20).Value = textBoxes[2].Texts;
                cmd.Parameters.Add("@RegNumberPhone", SqlDbType.NVarChar, 20).Value = (cmBox.SelectedItem.ToString() + "-" + textBoxes[3].Texts).Trim();
                cmd.Parameters.Add("@RegType", SqlDbType.NVarChar, 10).Value = RegTypeTxt;
                cmd.Parameters.Add("@RegImagePath", SqlDbType.NVarChar, 500).Value = PhoneNumberAdd.ImagePath;
                cmd.Parameters.Add("@RegEmail", SqlDbType.NVarChar, 50).Value = $"{textBoxes[4].Texts}";
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(textBoxes[0].Texts);
                cmd.ExecuteNonQuery();
                HomePage.DataGridUpdateList(dgv);
                MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }

        }
        public static void RegPasswordUpdate(RJconpanents.RJtextBox txtBox, string email)
        {
            try
            {
                con.Open();

                var sql = string.Format("UPDATE Tbl_LoginUser SET UserPassword = '{0}' WHERE UserEmail = '{1}'", SHA256(SHA256(txtBox.Texts)), email);

                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }
        }
        public static void RegDelete(DataGridView dgv, bool isAdmin) //+
        {
            try
            {
                con.Open();

                if (!isAdmin)
                {
                    object selectedRowsValue = dgv.SelectedRows[0].Cells[3].Value;
                    var sql = string.Format("RegDelete");
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = UserID;
                    cmd.Parameters.Add("@RegNumberPhone", SqlDbType.NVarChar, 20).Value = selectedRowsValue;
                    cmd.ExecuteNonQuery();
                    HomePage.DataGridUpdateList(dgv);

                    MessageBox.Show("\"" + selectedRowsValue + "\" Numaraya Sahip Olan Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    object selectedRowsValue = dgv.SelectedRows[0].Cells[1].Value;
                    var sql = string.Format("UserDelete");
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = selectedRowsValue;
                    cmd.ExecuteNonQuery();
                    HomePage.DataGridUpdateList(dgv);

                    MessageBox.Show("\"" + selectedRowsValue + "\" Kullanıcı Adına Sahip Olan Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }
        }
        public static void RegDeleteAll(DataGridView dgv, bool isAdmin)
        {
            try
            {
                con.Open();

                if (!isAdmin)
                {
                    var sql = string.Format("RegDeleteAll");
                    cmd = new SqlCommand(sql, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
                    cmd.ExecuteNonQuery();
                    HomePage.DataGridUpdateList(dgv);

                    MessageBox.Show("Tüm Kayıtlar Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }
        }
        public static void RegSearch(DataGridView dgv, RJconpanents.RJtextBox txtBoxSearching)
        {
            try
            {
                if (!HomePage.admin)
                    cmd = new SqlCommand("SELECT * FROM Tbl_Registry WHERE UserID = " + UserID + " AND (RegName like '%" + txtBoxSearching.Texts + "%' OR RegNumberPhone like '_" + txtBoxSearching.Texts + "%') ORDER BY RegName ASC", con);

                else
                    cmd = new SqlCommand("SELECT * FROM Tbl_LoginUser WHERE (IsAdmin <> 1) AND (UserName like '" + txtBoxSearching.Texts + "%') ORDER BY UserName ASC", con);
                SqlDataAdapter daSecond = new SqlDataAdapter(cmd);
                DataSet dsSecond = new DataSet();
                daSecond.Fill(dsSecond);
                dgv.DataSource = dsSecond.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        public static void RegSearch(RJconpanents.RJtextBox txtboxMail) //+
        {
            con = new SqlConnection(conAdress);
            string email = default;
            bool count = true;

            try
            {
                con.Open();

                var sql = string.Format("RegSearch");
                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserEmail", SqlDbType.NVarChar, 50).Value = $"{txtboxMail.Texts}";
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                    while (reader.Read() && count)
                    {
                        count = false;
                        email = reader[0].ToString();
                        ForgotPassword.EmailSend(email);

                        itSend = true;
                        MessageBox.Show("gönderildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // degisicek
                    }
                else
                    MessageBox.Show("Girmiş Olduğunuz E-Mail Adresine Ait Kullanıcı Bulunamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                reader.Close();
                con.Close();
            }
        }
        public static void RegLogin(Form form, RJconpanents.RJtextBox username, RJconpanents.RJtextBox password)
        {
            try
            {
                con = new SqlConnection(conAdress);
                con.Open();

                hashedPassword = SHA256(SHA256(password.Texts));

                var sql = string.Format("RegLogin");

                cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserName", SqlDbType.NVarChar, 15).Value = username.Texts;
                cmd.Parameters.Add("@UserPassword", SqlDbType.NVarChar, 64).Value = hashedPassword;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    if (IsAdmin == (bool)dr["IsAdmin"])
                    {
                        UserID = (int)dr["ID"];
                        HomePage homePage = new HomePage(UserID);
                        homePage.Show();
                        homePage.lblUserName.Text = "Hoşgeldin: " + username.Texts;
                        form.Hide();
                    }
                    else
                    {
                        HomePage homePage = new HomePage(true, username.Texts);
                        homePage.Show();
                        homePage.lblUserName.Text = "Hoşgeldin: " + username.Texts;
                        form.Hide();
                    }
                }
                else
                {
                    username.Focus();
                    MessageBox.Show("Hatalı Kullancı Adı veya Şifre Girdiniz. Lütfen Tekrar Deneyiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally { con.Close(); }
        }
        public static Tuple<int, int, int, int, int> RegStatistics()
        {
            con.Open();
            SqlCommand cmdStatistic;
            SqlDataAdapter daStatistic;
            DataSet dsStatistic;

            int[] types = new int[5];

            string[] sql = new string[5]
            {
                 string.Format("SELECT COUNT(RegType) FROM Tbl_Registry WHERE UserID = {0}", UserID).ToString(),
                 string.Format("SELECT COUNT(RegType) FROM Tbl_Registry WHERE UserID = {0} and RegType = 'ERKEK'",UserID).ToString(),
                 string.Format("SELECT COUNT(RegType) FROM Tbl_Registry WHERE UserID = {0} and RegType = 'KADIN'",UserID).ToString(),
                 string.Format("SELECT COUNT(RegType) FROM Tbl_Registry WHERE UserID = {0} and RegType = 'SABİT'",UserID).ToString(),
                 string.Format("SELECT COUNT(UserName) FROM Tbl_LoginUser WHERE IsAdmin <> {0}", 1).ToString()
            };


            for (int i = 0; i < sql.Length; i++)
            {
                cmdStatistic = new SqlCommand(sql[i], con);
                daStatistic = new SqlDataAdapter(cmdStatistic);
                dsStatistic = new DataSet();
                daStatistic.Fill(dsStatistic);
                types[i] = Convert.ToInt32(dsStatistic.Tables[0].Rows[0].ItemArray[0]);
            }

            con.Close();

            return Tuple.Create(types[0], types[1], types[2], types[3], types[4]);
        }

        //Encryption Password
        static string SHA256(string rawData)
        {
            SHA256 sha256Encrypting = new SHA256CryptoServiceProvider();
            byte[] bytes = sha256Encrypting.ComputeHash(Encoding.UTF8.GetBytes(rawData));

            StringBuilder stringBuilder = new StringBuilder();

            foreach (var item in bytes)
                stringBuilder.Append(item.ToString("x2"));

            return stringBuilder.ToString();
        }
        //Download Directory
        public static void ExportGridTopPDF(DataGridView dgv, string filename)
        {
            try
            {
                PdfPTable pdfPTable;
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, "windows-1254", BaseFont.EMBEDDED);
                if (IsAdmin)
                {
                    pdfPTable = new PdfPTable(dgv.Columns.Count - 3);
                    pdfPTable.DefaultCell.Padding = 3;
                    pdfPTable.WidthPercentage = 100;
                    pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfPTable.DefaultCell.BorderWidth = 1;
                }
                else
                {
                    pdfPTable = new PdfPTable(dgv.Columns.Count - 3);
                    pdfPTable.DefaultCell.Padding = 3;
                    pdfPTable.WidthPercentage = 100;
                    pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfPTable.DefaultCell.BorderWidth = 1;
                }

                Font text = new Font(bf, 10, Font.NORMAL);

                //Add Header
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    if (IsAdmin)
                    {
                        if (column.HeaderText != "ID" && column.HeaderText != "RegImagePath" && column.HeaderText != "UserID")
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text))
                            {
                                BackgroundColor = new BaseColor(240, 240, 240)
                            };
                            pdfPTable.AddCell(cell);
                        }
                    }
                    else
                    {
                        if (column.HeaderText != "UserPassword" && column.HeaderText != "IsAdmin" && column.HeaderText != "ID")
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text))
                            {
                                BackgroundColor = new BaseColor(240, 240, 240)
                            };
                            pdfPTable.AddCell(cell);
                        }
                    }
                }

                //Add datarow
                foreach (DataGridViewRow row in dgv.Rows)
                    foreach (DataGridViewCell cell in row.Cells)
                        if (IsAdmin)
                        {
                            if (cell.ColumnIndex != 0 && cell.ColumnIndex != 5 && cell.ColumnIndex != 7)
                                pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                        }
                        else
                        {
                            if (cell.ColumnIndex != 0 && cell.ColumnIndex != 2 && cell.ColumnIndex != 4)
                                pdfPTable.AddCell(new Phrase(cell.Value.ToString(), text));
                        }

                var saveFileDialoge = new SaveFileDialog();
                saveFileDialoge.FileName = filename;
                saveFileDialoge.DefaultExt = ".PDF";

                if (saveFileDialoge.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10F, 10F, 10F, 0F);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdfPTable);
                        pdfdoc.Close();
                        stream.Close();
                    }
                }
            }
            catch (PdfException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
        //Directory To Send
        public class DictionaryList
        {
            public string RegName { get; set; }
            public string RegSurname { get; set; }
            public string RegNumberPhone { get; set; }
            public string RegType { get; set; }
            public string RegImagePath { get; set; }
            public string RegEmail { get; set; }
            public int UserID { get; set; }
        }
    }
}
