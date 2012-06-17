using System.Windows.Forms;

namespace GestiuneApplication.Interfaces
{
    internal interface IRaportTreeNodeComponent
    {
        UserControl Control { get; }
        string Description { get; }
    }
}
