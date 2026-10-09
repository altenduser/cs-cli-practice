using System.Text;
public class _2dre
{
    public int[,] grid = new int[0,0];
    public Dictionary<int, char> objs = new();
    public void AppendObj(int val, char obj) => objs[val]=obj;
    public void InitialiseGrid(int x, int y) => grid = new int[y, x];
    public string lr()
    {
        StringBuilder sb = new();
        for (int y = 0; y < grid.GetLength(0); y++)
        {
            for (int x = 0; x < grid.GetLength(1); x++)
                if (objs.ContainsKey(grid[y,x]))
                sb.Append($" {objs[grid[y,x]]} ");
                else sb.Append("   ");
            sb.AppendLine();
        }
        return sb.ToString();
    }
}