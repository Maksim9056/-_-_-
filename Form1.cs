using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private BinaryTree tree;

        public Form1()
        {
            InitializeComponent();
            tree = new BinaryTree();

        }


        private void btnDeleteLeaf_Click(object sender, EventArgs e)
        {
            int leafValue = Convert.ToInt32(txtLeafValue.Text);
            tree.DeleteLeaf(tree.Root,leafValue);
            treeView1.Nodes.Clear(); 
            tree.FillTreeView(treeView1);
        }






        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnInsertLeft_Click(object sender, EventArgs e)
        {
            int parentValue = Convert.ToInt32(txtParentValue.Text);
            int childValue = Convert.ToInt32(txtChildValue.Text);

            tree.InsertLeft(parentValue, childValue);

            treeView1.Nodes.Clear();
            tree.FillTreeView(treeView1);
        }

        private void btnInsertRight_Click(object sender, EventArgs e)
        {
            int parentValue = Convert.ToInt32(txtParentValue.Text);
            int childValue = Convert.ToInt32(txtChildValue.Text);

            tree.InsertRight(parentValue, childValue);

            treeView1.Nodes.Clear();
            tree.FillTreeView(treeView1);
        }
    }
    public class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTree
    {
        public Node Root { get; set; }

        public BinaryTree()
        {
            Root = null;
        }

        public Node DeleteLeaf(Node root, int value)
        {
            if (root == null)
            {
                //"Дерево пустое. Нечего удалять");
                return null;
            }

            // Если текущий узел является листом и имеет значение, равное искомому значению,
            // то возвращаем null в качестве родительского узла
            if (root.Left == null && root.Right == null && root.Value == value)
            {
                return null;
            }

            // Обрабатываем левое и правое поддерево рекурсивно
            root.Left = DeleteLeaf(root.Left, value);
            root.Right = DeleteLeaf(root.Right, value);

            return root;
        }




        public void InsertLeft(int parentValue, int childValue)
        {
            Node newNode = new Node(childValue);

            if (Root == null)
            {
                Root = new Node(parentValue);
            }

            Node parentNode = FindNode(parentValue);
            if (parentNode != null)
            {
                if (parentNode.Left == null)
                {
                    parentNode.Left = newNode;
                }
                else
                {
                    MessageBox.Show("Left child already exists for node " + parentValue);
                }
            }
            else
            {
                MessageBox.Show("Parent node not found");
            }
        }

        public void InsertRight(int parentValue, int childValue)
        {
            Node newNode = new Node(childValue);

            if (Root == null)
            {
                Root = new Node(parentValue);
            }

            Node parentNode = FindNode(parentValue);
            if (parentNode != null)
            {
                if (parentNode.Right == null)
                {
                    parentNode.Right = newNode;
                }
                else
                {
                    MessageBox.Show("Right child already exists for node " + parentValue);
                }
            }
            else
            {
                MessageBox.Show("Parent node not found");
            }
        }
       
        private Node FindNode(int value)
        {
            return FindNodeRecursive(Root, value);
        }

        private Node FindNodeRecursive(Node currentNode, int value)
        {
            if (currentNode == null)
            {
                return null;
            }

            if (currentNode.Value == value)
            {
                return currentNode;
            }

            Node leftResult = FindNodeRecursive(currentNode.Left, value);
            if (leftResult != null)
            {
                return leftResult;
            }

            Node rightResult = FindNodeRecursive(currentNode.Right, value);
            if (rightResult != null)
            {
                return rightResult;
            }

            return null;
        }

        public void FillTreeView(System.Windows.Forms.TreeView treeView)
        {
            treeView.Nodes.Clear();
            FillTreeViewRecursive(Root, null, treeView.Nodes);
        }

        private void FillTreeViewRecursive(Node currentNode, TreeNode parentNode, TreeNodeCollection nodeCollection)
        {
            if (currentNode != null)
            {
                TreeNode newNode;
                if (parentNode == null)
                {
                    newNode = nodeCollection.Add(currentNode.Value.ToString());
                }
                else
                {
                    newNode = parentNode.Nodes.Add(currentNode.Value.ToString());
                }

                FillTreeViewRecursive(currentNode.Left, newNode, newNode.Nodes);
                FillTreeViewRecursive(currentNode.Right, newNode, newNode.Nodes);
            }
        }
    }
}
