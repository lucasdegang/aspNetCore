namespace Application.Commands.DataType
{
    public class DataTypes
    {
        bool completo = false;
        char genero = 'F';
        char letra = '\u0041';
        byte n1 = 126;
        int n2 = 1000;
        int n3 = 2147483647;
        long n4 = 2147483648L;
        float n5 = 4.5f;
        double n6 = 4.5;

        // nullable - 2 types to declare. Example.
        Nullable<double> numNull1 = null;
        double? numNull2 = null;
        double? numNull3 = 10.0;

        String nome = "Maria Green";
        Object obj1 = "Alex Brown";
        Object obj2 = 4.5f;
    }
}
