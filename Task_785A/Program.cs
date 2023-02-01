/* 
 * Task 785A
 * 
 * https://codeforces.com/problemset/problem/785/A
 */

internal class Program
{
    /// <summary>
    /// Set of polyhedra and number of their edges.
    /// </summary>
    private static readonly Dictionary<string, int> polyhedraEdges = new()
        {
            { "Tetrahedron", 4 },
            { "Cube", 6 },
            { "Octahedron", 8 },
            { "Dodecahedron", 12 },
            { "Icosahedron", 20 }
        };

    private static void Main(string[] args)
    {
        // Read the number of polyhedra.
        int numberOfPolyhedra = int.Parse(Console.ReadLine());

        // Read all polyhedra and calculate the total number of edges.
        int edgeTotalAmount = 0;
        for (int i = 0; i < numberOfPolyhedra; i++)
        {
            string polyhedronType = Console.ReadLine();
            edgeTotalAmount += polyhedraEdges[polyhedronType];
        }

        // Write the result.
        Console.WriteLine(edgeTotalAmount);
    }
}
