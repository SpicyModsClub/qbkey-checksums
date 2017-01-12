using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DamienG.Security.Cryptography;

namespace GH3_Checksums
{
    using System.IO;

    public partial class frmChecksumUtility : Form {
        private Dictionary<uint, string[]> DebugItems;

        public frmChecksumUtility() {
            InitializeComponent();
        }

        private void btnCalculateChecksum_Click(object sender, EventArgs e) {
            var input = Encoding.ASCII.GetBytes(txtInput.Text);
            txtResult.Text = CalculateChecksum(input).ToString("X8");
        }

        private UInt32 CalculateChecksum(byte[] input) {
            return ~Crc32.Compute(input);
        }

        private void btnLookUpName_Click(object sender, EventArgs e) {
            uint value;
            string bytes = SanitizeChecksum();
            try {
                value = Convert.ToUInt32(bytes, 16);
                if (DebugItems == null) {
                    MessageBox.Show(
                        "The first time you use this feature, the application has to parse the debug keys.  This can take a long time.");
                    Cursor.Current = Cursors.WaitCursor;
                    Application.DoEvents();
                    DebugItems = LoadDebugItems();
                    Cursor.Current = Cursors.Default;
                }
                if (DebugItems.ContainsKey(value)) {
                    txtResult.Text = string.Join("\r\n", DebugItems[value]);
                }
                else {
                    MessageBox.Show("Failed to find item in debug items.");
                }
            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException) {
                MessageBox.Show("Could not read checksum as hex number.");
                MessageBox.Show(ex.Message);
            }
        }

        private Dictionary<uint, string[]> LoadDebugItems() {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceStream = assembly.GetManifestResourceStream("GH3_Checksums.dbg.pak.xen");
            if (resourceStream == null) throw new NullReferenceException("Failed to load the debug names");

            var tempResult = new Dictionary<uint, List<string>>();
            var result = new Dictionary<uint, string[]>();

            using (var sr = new StreamReader(resourceStream)) {
                while (!sr.EndOfStream) {
                    string[] parts = sr.ReadLine().Split(' ');
                    if (parts.Length <= 1) {
                        continue;
                    }

                    uint key;

                    try {
                        // tryparse is messy because of stripping the hex specifier
                        key = Convert.ToUInt32(parts[0], 16);
                    }
                    catch {
                        continue;
                    }

                    var value = string.Join(" ", parts.Skip(1)).ToLowerInvariant();
                    if (!tempResult.ContainsKey(key)) {
                        tempResult.Add(key, new List<string>());
                    }
                    tempResult[key].Add(value);
                }

                //Get only distinct values.  Differences occur generally when a key is used for a file path as well
                //as the file name even when the checksum is not actually that of the file path.
                foreach (var kv in tempResult) {
                    kv.Value.Sort();
                    result.Add(kv.Key, kv.Value.Distinct().ToArray());
                }

                return result;
            }
        }

        private void btnLookUpSwapped_Click(object sender, EventArgs e)
        {
            string bytes = SanitizeChecksum();

            txtInput.Text = "0x" + bytes[6] + bytes[7] + bytes[4] + bytes[5] + bytes[2] + bytes[3] + bytes[0]
            + bytes[1];
            btnLookUpName_Click(sender, e);
        }

        private string SanitizeChecksum()
        {
            if (txtInput.Text.StartsWith("0x")) {
                return txtInput.Text.Replace(" ", "").Substring(2, 8);
            } else {
                return txtInput.Text.Replace(" ", "").Substring(0, 8);
            }
        }
    }
}
