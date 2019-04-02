using UnityEngine;

public class GameBoard : MonoBehaviour
{
    [Header("Board")]
    public int width = 10;
    public int height = 10;
    public float unitSize = 0.5f;

    [Header("Physics")]
    [Tooltip("The switch (in units/sec) that blocks fall.")]
    public float fallrate = 0.2f;
    public Block[] blockPrefabs;

    private Block[,] board;

    void Start()
    {
        board = new Block[width, height];

        float center_width = width * unitSize / 2f - unitSize / 2f;
        float center_height = height * unitSize / 2f - unitSize / 2f;

        for (int x = 0; x < width; x++)
            for (int y = 0; y < height; y++)
            {
                board[x, y] = blockPrefabs[Random.Range(0, blockPrefabs.Length)];
                board[x, y] = Instantiate(board[x, y]);

                float x_pos = x * unitSize - center_width;
                float y_pos = y * unitSize - center_height;

                board[x, y].transform.position = new Vector3(x_pos, y_pos, 0f);
            }
    }

    void FixedUpdate()
    {

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawWireCube(transform.position, new Vector3(width * unitSize, height * unitSize, 1f));
    }
}
