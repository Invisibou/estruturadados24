using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ArvoreBinaria
{
    public class BinaryTreeNode<T> : TreeNode<T>
    {
        public BinaryTreeNode()
        {
            base.Children = 
                new List<TreeNode<T>>();
        }
        //Aqui ele atribuiu a árvore binária a possibilidade de ter dois filhos, a partir do left e right, se tivesse só 1 deles, a árvore só poderia ser "manca"
        public BinaryTreeNode<T> Left //Atributo que especifica o nó da árvore da esquerda, o nome é Left.
        {
            get {return (BinaryTreeNode<T>)Children[0]; }
            set {Children[0] = value; }
        }
                public BinaryTreeNode<T> Right //Atributo que especifica o nó da árvore da direita, o nome é right.
        {
            get {return (BinaryTreeNode<T>)Children[1]; }
            set {Children[1] = value; }
        }
    }
}