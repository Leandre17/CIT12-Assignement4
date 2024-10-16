
using System.Data;
using Npgsql;



var connectionString = "host=localhost;db=northwind;uid=postgres;pwd=";


using var connection = new NpgsqlConnection(connectionString);
connection.Open();


// cmd.Connection = connection;
// cmd.CommandText = "select * from categories";

// using var reader = cmd.ExecuteReader();

// while(reader.Read())
// {
//     Console.WriteLine(reader.GetString(2));
// }

void Test()
{
    using var cmd = new NpgsqlCommand();
    cmd.Connection = connection;
    cmd.CommandText = "select * from orders";
    using var reader = cmd.ExecuteReader();
    while (reader.Read())
    {
        try
        {
            Console.Write(reader.GetInt32(0) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetString(1) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetInt32(2) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetDateTime(3) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetDateTime(4) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetDateTime(5) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetInt32(6) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetString(7) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetString(8) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetString(9) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetString(10) + " ");
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null ");
        }
        try
        {
            Console.Write(reader.GetString(11));
        }
        catch (Exception e)
        {
            Console.Error.Write(e.Message);
            Console.Write("null");
        }
        Console.Write("\n");
    }
}

Test();