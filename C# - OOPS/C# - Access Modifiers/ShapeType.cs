namespace C____Access_Modifiers
{
    // Enum Type which supports Circles and Rectangles and other shapes
    // Problem -> every time new shape added -> need to recompile the classes that reference this
    // Tight Coupling is there

    public enum ShapeType{
        Circle,
        Rectangle, 
        Triangle
    }
}