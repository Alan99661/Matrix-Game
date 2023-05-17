using ATOOPS966vt.Interfaces.GamePieces;

namespace ATOOPS966vt.Interfaces.GameLoop
{
    internal interface IOutOFBoundsCheck
    {
        bool OFBCheck(IGrid grid, int x, int y);
    }
}