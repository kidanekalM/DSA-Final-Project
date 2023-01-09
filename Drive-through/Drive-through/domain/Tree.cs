using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Drive_through.domain
{
    public class TreeNode
    {
        public Food data;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(Food item)
        {
            data = item;
        }
    }
    public class Tree
    {
        public TreeNode root;
        public Food Search(string name)
        {
            TreeNode temp = root;
            Food SearchResult = null;
            while(temp != null)
            {
                
                int result = string.Compare(temp.data.Name, name, true);
                if (result == 0)
                {
                    SearchResult = temp.data;
                }
                else if (result > 0)
                {
                    temp = temp.left;
                }
                else
                {
                    temp = temp.right;
                }
                
            }
            return SearchResult;
        }
        public void Insert(Food item)
        {
            if (root == null)
            {
                root = new TreeNode(item);
            }
            else
            {
                TreeNode temp= root;
                while (temp != null)
                {
                    int result = string.Compare(temp.data.Name, item.Name, true);
                    if(result > 0)
                    {
                        if(temp.left == null)
                        {
                            temp.left = new TreeNode(item);
                            return;
                        }
                        
                        temp = temp.left;
                        
                    }
                    else if(result < 0)
                    {
                        if(temp.right == null)
                        {
                            temp.right = new TreeNode(item);
                            return;
                        }
                        
                        temp = temp.right;
                    }
                    else
                    {
                        Console.WriteLine("You are inserting the same value ! ");
                    }
                }
            }
        }
    }
}
