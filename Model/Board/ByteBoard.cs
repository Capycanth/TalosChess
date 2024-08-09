namespace TalosChess.Model.Board
{
    public class ByteBoard
    {
        public PieceByte[] _byteBoard = new PieceByte[64];

        public ByteBoard()
        {

        }
    }

    public enum PieceByte : byte
    {
        NONE =          0b00000000,

        WHITE_KING =    0b00000001,
        WHITE_QUEEN =   0b00000010,
        WHITE_ROOK =    0b00000011,
        WHITE_BISHOP =  0b00000100,
        WHITE_KNIGHT =  0b00000101,
        WHITE_PAWN =    0b00000110,

        BLACK_KING =    0b00010000,
        BLACK_QUEEN =   0b00100000,
        BLACK_ROOK =    0b00110000,
        BLACK_BISHOP =  0b01000000,
        BLACK_KNIGHT =  0b01010000,
        BLACK_PAWN =    0b01100000,
    }
}
