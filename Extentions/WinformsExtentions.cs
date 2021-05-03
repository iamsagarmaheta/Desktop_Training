using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSTBilling
{
    public static class WinformsExtentions
    {

        public static string GetDescription<T>(this T e) where T : IConvertible
        {
            if (e is Enum)
            {
                Type type = e.GetType();
                Array values = System.Enum.GetValues(type);

                foreach (int val in values)
                {
                    if (val == e.ToInt32(CultureInfo.InvariantCulture))
                    {
                        var memInfo = type.GetMember(type.GetEnumName(val));
                        var descriptionAttribute = memInfo[0]
                            .GetCustomAttributes(typeof(DescriptionAttribute), false)
                            .FirstOrDefault() as DescriptionAttribute;

                        if (descriptionAttribute != null)
                        {
                            return descriptionAttribute.Description;
                        }
                    }
                }
            }
            return null; // could also return string.Empty
        }


        public static string SelectBackupLocation()
        {
            SaveFileDialog backupFile = new SaveFileDialog();
            backupFile.Title = "Backup Data";
            backupFile.CheckPathExists = true;
            backupFile.DefaultExt = "sql";
            backupFile.Filter = "Backup File (*.sql)|*.sql";
            backupFile.RestoreDirectory = true;
            if (backupFile.ShowDialog() == DialogResult.OK)
            {
                return backupFile.FileName;
            }
            return null;
        }

        public static string SelectRestoreFile()
        {
            OpenFileDialog restoreFile = new OpenFileDialog();
            restoreFile.Filter = "Backup File (*.sql)|*.sql";
            restoreFile.Title = "Restore Data";
            if (restoreFile.ShowDialog() == DialogResult.OK)
            {
                return restoreFile.FileName;
            }
            return null;
        }

        public static double GetDouble(this NumericUpDown data)
        {
            return (double)data.Value;
        }

        public static int GetInt(this NumericUpDown data)
        {
            return (int)data.Value;
        }

        public static void ShowError(this string Error)
        {
            MessageBox.Show(Error, "Just A Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void ShowAccessDenied()
        {
            "Access Denied".ShowError();
        }

        public static void ShowInformation(this string Information)
        {
            MessageBox.Show(Information, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool ConfirmDialouge(this string Question)
        {
            if (MessageBox.Show(Question, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            return true;
        }

        public static double GetTotalOfColumn(this DataGridView dataGridView, string columnName)
        {
            double totalAmount = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                totalAmount += dataGridView.Rows[i].Cells[columnName].GetString().ToDouble();
            }
            return totalAmount;
        }

        public static void CopyToClipBoard(this string S)
        {
            S += " ";
            Clipboard.SetText(S);
            MessageBox.Show("This Is Not An Error, It's For Developer's Ref." + Environment.NewLine + Environment.NewLine + Environment.NewLine + S);
        }

        public static void ShowRowNumbers(this DataGridView dataGridView, DataGridViewColumn columnName)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[columnName.Name].Value = (row.Index + 1).ToString();
            }
        }
        

        public static void SuggestCustomSource(this TextBox T, string[] a)
        {
            T.AutoCompleteMode = AutoCompleteMode.Suggest;
            T.AutoCompleteSource = AutoCompleteSource.CustomSource;
            T.AutoCompleteCustomSource.AddRange(a);
        }

        public static string GetString(this TextBox T)
        {
            return T.Text.Trim();
        }

        public static int GetStringLength(this TextBox T)
        {
            return T.Text.Trim().Length;
        }

        public static bool IsEmpty(this TextBox T)
        {
            return T.Text.Trim().Length == 0 ? true : false;
        }

        public static string GetString(this DataGridViewCell gvc)
        {
            return gvc.Value == null ? "" : gvc.Value.ToString().Trim();
        }

        public static void ShowDataSaved()
        {
            "Details Saved Successfully".ShowInformation();
        }

        public static void ShowDataDeleted()
        {
            "Details Deleted Successfully".ShowInformation();
        }

        public static void ShowDataExported()
        {
            //"Details Exported Successfully".ShowInformation();
        }

        public static bool ConfirmDelete()
        {
            return "Are You Sure You Want To Delete Information ? ".ConfirmDialouge();
        }

        public static bool ConfirmToggleStatus()
        {
            return "Are You Sure You Want To Change Details ? ".ConfirmDialouge();
        }

        public static string GetApplicationStartupPath()
        {
            return Application.StartupPath;
        }

        public static void CreateFolderIfMissing(this string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }

        public static string getConfigFile()
        {
            return GetApplicationStartupPath() + @"\config.json";
        }
    }
}
