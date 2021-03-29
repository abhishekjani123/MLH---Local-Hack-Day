using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Prac8
{
 public partial class Form1 : Form
 {
 public Form1()
 {
 InitializeComponent();
 }
 private void newToolStripMenuItem_Click(object sender, EventArgs e)
 {
 richTextBox1.Clear();
 }
 private void saveToolStripMenuItem_Click(object sender, EventArgs e)
 {
 SaveFileDialog sv = new SaveFileDialog();
 sv.InitialDirectory = "E:\\";
 sv.Filter = "*.txt|*.txt|*.doc|*.doc|*.html|*.html|Select All|*.*";
 if(sv.ShowDialog()==System.Windows.Forms.DialogResult.OK)
 {
 if(!string.IsNullOrEmpty(sv.FileName))
 {
 FileStream fs = new FileStream(sv.FileName, FileMode.Create);
 StreamWriter sw = new StreamWriter(fs);
 String s = richTextBox1.Text;
 sw.Write(s);
 sw.Close();
 fs.Close();
 }
 }
 
 }
 private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
 {
 SaveFileDialog sv = new SaveFileDialog();
 sv.InitialDirectory = "E:\\";
 sv.Filter = "*.txt|*.txt|*.doc|*.doc|*.html|*.html|Select All|*.*";
 if (sv.ShowDialog() == System.Windows.Forms.DialogResult.OK)
 {
 if (!string.IsNullOrEmpty(sv.FileName))
 {
 FileStream fs = new FileStream(sv.FileName, FileMode.Create);
 StreamWriter sw = new StreamWriter(fs);
 String s = richTextBox1.Text;
 sw.Write(s);
 sw.Close();
 fs.Close();
 }
 }
 }
 private void openToolStripMenuItem_Click(object sender, EventArgs e)
 {
 OpenFileDialog od = new OpenFileDialog();
 od.InitialDirectory = "E:\\";
 od.Filter = "*.txt|*.txt|*.doc|*.doc";
 if(od.ShowDialog() == System.Windows.Forms.DialogResult.OK)
 {
 if(!string.IsNullOrEmpty(od.FileName))
 {
 FileStream fs = new FileStream(od.FileName, FileMode.Open);
 StreamReader sr = new StreamReader(fs);
 String s = richTextBox1.Text;
 sr.Read();
 sr.Close();
 fs.Close();
 }
 }
 }
 private void exitToolStripMenuItem_Click(object sender, EventArgs e)
 {
 this.Close();
 }
 private void cutToolStripMenuItem_Click(object sender, EventArgs e)
 {
 richTextBox1.Cut();
 }
 private void copyToolStripMenuItem_Click(object sender, EventArgs e)
 {
 richTextBox1.Copy();
 }
 private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
 {
 richTextBox1.Paste();
 }
 private void undoToolStripMenuItem_Click(object sender, EventArgs e)
 {
 richTextBox1.Undo();
 }
 private void redoToolStripMenuItem_Click(object sender, EventArgs e)
 {
 richTextBox1.Redo();
 }
 private void fontToolStripMenuItem_Click(object sender, EventArgs e)
 {
 FontDialog fd = new FontDialog();
 if (fd.ShowDialog() == DialogResult.OK)
 {
 richTextBox1.SelectionFont = fd.Font;
 }
 }
 private void colorToolStripMenuItem_Click(object sender, EventArgs e)
 {
 ColorDialog cd = new ColorDialog();
 if (cd.ShowDialog() == DialogResult.OK)
 {
 richTextBox1.SelectionColor = cd.Color;
 }
 }
