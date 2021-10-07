using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.Mime.MediaTypeNames;


namespace clrRobotAdmin


{

    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            

        }

        private void btn1_Click(object sender, EventArgs q)
        {

            var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");

            //opening config file
            string strLine;
            var varConfig = "c:\\reskit\\config.txt";
            txtLog.Text = txtLog.Text + dateAsString + ": "+ "Reading config file" + "\r\n";

            using (var reader = new StreamReader(varConfig))
            {
                while (!reader.EndOfStream)
                {
                    //Console.WriteLine(reader.ReadLine());
                    strLine = reader.ReadLine();
                    dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                    txtLog.Text = txtLog.Text + dateAsString + ": " + strLine + "\r\n";

                }
            }

            dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
            txtLog.Text = txtLog.Text + dateAsString + ": " + "End of config file" + "\r\n";


            }

        private void btn2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(new LBItem("Abrir PDF", 1));
            ListBox1.Items.Add(new LBItem("Renombrar PDF", 2));
            ListBox1.Items.Add(new LBItem("Mover PDF", 2));
            //
            // para trabajar con cadenas
            // ListBox1.Items.Add("Cadena 1");
            //ListBox1.Items.Add("Cadena 2");
            //
            // para trabajar con Integer
            // ListBox1.Items.Add(125);
            // ListBox1.Items.Add(250);


            TreeNode node1 = new TreeNode();
            node1.Text = "Raiz";
            node1.Tag = "Raiz";
            /*
                        TreeNode node2 = new TreeNode();
                        node2.Text = "Renombrados";
                        node2.Tag = "Renombrados";

                        TreeNode node3 = new TreeNode();
                        node3.Text = "No Renombrados";
                        node3.Tag = "No Renombrados";

                        TreeNode node4 = new TreeNode();
                        node4.Text = "Otros";
                        node4.Tag = "Otros";


                        /// Agregamos el nodo1_1 a el nodo1
                        node1.Nodes.Add(node2);
                        node1.Nodes.Add(node3);
                        node1.Nodes.Add(node4);
            */
            /// Agregamos el nodo1 a el TreeView
            treeView1.Nodes.Add(node1);
            

        }

        private void treeView1_Click(object sender, EventArgs e)
        
        {
            var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");

            TreeViewHitTestInfo info = treeView1.HitTest(treeView1.PointToClient(Cursor.Position));
            if (info != null)
            dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
            txtLog.Text = txtLog.Text + dateAsString + ": " + "\r\n";
            MessageBox.Show(info.Node.Text);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");

            TreeViewHitTestInfo info = treeView1.HitTest(treeView1.PointToClient(Cursor.Position));
            if (info != null)
                //MessageBox.Show(info.Node.Text);

               // txtLog.Text = txtLog.Text + dateAsString + ": " +info.Node.Text + "\r\n";
            //MessageBox.Show(info.Node.Text);
            //MessageBox.Show(this.treeView1.SelectedNode.Name);
            txtLog.Text = txtLog.Text + dateAsString + ": " + this.treeView1.SelectedNode.Name + "\r\n";


            //run selected files
            if (this.treeView1.SelectedNode.Name is "")
            {
                txtLog.Text = txtLog.Text + dateAsString + ": root selected. do nothing" + "\r\n";

            }

            else
            {

                if (Directory.Exists(this.treeView1.SelectedNode.Name))
                {
                    txtLog.Text = txtLog.Text + dateAsString + ": directory selected. do nothing" + "\r\n";


                }
                else
                {

                    txtLog.Text = txtLog.Text + dateAsString + ": file selected. Opening pdf reader" + "\r\n";
                    //MessageBox.Show(this.treeView1.SelectedNode.Name);
                    textBox2.Text = this.treeView1.SelectedNode.Name;
                }
            }
            

///


//DirectoryInfo myDocumentsFolder = new DirectoryInfo(@"W:\");
//DirectoryInfo[] myFolder = myDocumentsFolder.GetDirectories();
DirectoryInfo di = new DirectoryInfo(@"w:\");



            //TreeNode root = new TreeNode("MyDocuments");
            TreeNode root = new TreeNode("w:/");

            PopulateTreeFromDirectory(di, root);
            
            //PopulateTreeFromDirectory(V, root);
            this.treeView1.Nodes.Add(root);



        }

        private void PopulateTreeFromDirectory(DirectoryInfo currentDirectory, TreeNode currentNode)
            {

              //currentDirectory = "c:/";

            //for each sub directory in the directory
                DirectoryInfo[] subDirectories = currentDirectory.GetDirectories();
                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    //create a new node on the tree
                    TreeNode newDirectoryNode = new TreeNode();
                    newDirectoryNode.Name = subDirectory.FullName;
                    newDirectoryNode.Text = "\\" + subDirectory.Name;
                    //TODO: set a directory image
                    currentNode.Nodes.Add(newDirectoryNode);

                    //populate the tree from a directory, this time the sub directory
                    PopulateTreeFromDirectory(subDirectory, newDirectoryNode);
                }

                //for each file in the directory          
                FileInfo[] files = currentDirectory.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                foreach (FileInfo file in files)
                {
                    //create a new node on the tree
                    TreeNode newFileNode = new TreeNode();
                    newFileNode.Name = file.FullName;
                    newFileNode.Text = Path.GetFileName(file.FullName);
                    //TODO: set a file image
                    currentNode.Nodes.Add(newFileNode);
                }
            }



        /// <summary>
        /// ///
        /// 

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            
        }
        //
       

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // para que valga para cualquier tipo de datos
            object o = ListBox1.SelectedItem;
            //
            if (o is LBItem)
            {
                LBItem lbi;
                lbi = (LBItem)o;
                textBox1.Text = lbi.Contenido;
                //textBox2.Text = lbi.Valor.ToString();
            }
            else
            {
                textBox1.Text = ListBox1.SelectedItem.ToString();
                //textBox2.Text = "";
            }
            //
            //    LBItem lbi;
            //    lbi = (LBItem)ListBox1.SelectedItem;
            //    TextBox1.Text = lbi.Contenido;
            //    TextBox2.Text = lbi.Valor.ToString();
            //    // 
            //    // si el contenido es de tipo string;
            //    TextBox1.Text = ListBox1.SelectedItem.ToString();
            //    //
            //    // Si el contenido es de tipo int;
            //    int n = Convert.ToInt32(ListBox1.SelectedItem);
            //    TextBox1.Text = n.ToString();
            //    TextBox1.Text = ListBox1.SelectedItem.ToString();
        }

        private void Btn_Execute_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Abrir PDF")
            {
                var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                txtLog.Text = txtLog.Text + dateAsString + ": " + "Open PDF document" + "\r\n";
                //MessageBox.Show("ejecutando pdf .... " + this.treeView1.SelectedNode.Name + "\r\n");
            }
            else
            {
                if (textBox1.Text == "Renombrar PDF")
                {
                    maskedTextBox1.Visible = true;
                    btnRename.Visible = true;
                    var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                    txtLog.Text = txtLog.Text + dateAsString + ": " + "Rename PDF document" + "\r\n";
                    //MessageBox.Show("renombrar pdf .... " + this.treeView1.SelectedNode.Name + "\r\n");

                 }

                if (textBox1.Text == "Mover PDF")
                {
                    var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                    txtLog.Text = txtLog.Text + dateAsString + ": " + "Move PDF document" + "\r\n";
                    //MessageBox.Show("mover pdf a renamed.... " + this.treeView1.SelectedNode.Name + "\r\n");
                }
            }
            }


        private void btnRename_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {

                var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                txtLog.Text = txtLog.Text + dateAsString + ": " + "Mask complete. Renaming." + "\r\n";
                string strFilenameO = textBox2.Text;
                string strFilenameD = maskedTextBox1.Text;

                if (!File.Exists(maskedTextBox1.Text))
                {

                    dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                    txtLog.Text = txtLog.Text + dateAsString + ": " + "Renaming " + strFilenameO + " to " + strFilenameD + "\r\n";
                }
                else

                {
                    dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                    txtLog.Text = txtLog.Text + dateAsString + ": " + "File already exists. Canceling rename. " + strFilenameD + "\r\n";
                }  
            }
            else
            {
                var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
                txtLog.Text = txtLog.Text + dateAsString + ": " + "Mask incomplete" + "\r\n";

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            maskedTextBox1.Visible = false;
            btnRename.Visible = false;

        }
    }
    }
    //
    class LBItem
    {
        public string Contenido = " hola ";
        public int Valor = 2;
        //

        public LBItem(string c, int v)
        {
            Contenido = c;
            Valor = v;
        }
        //
        public override string ToString()
        {
            return Contenido;
        }
    }

    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    /*private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            var dateAsString = DateTime.Now.ToString("dd/MM/yyyy HHmmss");
            // Set the caption bar text of the form.  
            //listBox1.Items.Clear();
            this.Text = "tutorialspont.com";
            listBox1.Items.Add("Abrir PDF");
            listBox1.Items.Add("Renombrar PDF");
           // listBox1.Items.Clear();
            string selectedItem = listBox1.Items[listBox1.SelectedIndex].ToString();

            MessageBox.Show(listBox1.SelectedItem.ToString());


            txtLog.Text = txtLog.Text + dateAsString + ": file selected. Opening pdf reader";
          //   MessageBox.Show(this.treeView1.SelectedNode.Name);
            

         }

        */








///















//
