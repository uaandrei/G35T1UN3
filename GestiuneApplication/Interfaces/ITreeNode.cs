using System.Windows.Forms;

namespace GestiuneApplication.Interfaces
{
    interface ITreeNode
    {
        string NodeName { get; }
        string ParentName { get; }
        UserControl Control { get; }
        string Description { get; }
    }
}
