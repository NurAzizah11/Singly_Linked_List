    using System;



    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }

class List
{
    Node START;
    public List()
    {
        START = null;
    }

    public void addNode()/*Method untuk menambahkan sebuah Node kedalam list*/
    {
        int nim;
        string nm;
        Console.Write("\nMasukkan nomer Mahasiswa: ");
        nim = Convert.ToInt32(Console.ReadLine());
        Console.Write("\nMasukkan nama Mahasiswa: ");
        nm = Console.ReadLine();
        Node nodeBaru = new Node();
        nodeBaru.noMhs = nim;
        nodeBaru.nama = nm;

        if (START == null || nim <= START.noMhs)
        {
            if ((START == null) && (nim == START.noMhs))
            {
                Console.WriteLine("\nNomor mahasiswa sama tidak diizinkan");
                return;
            }
            nodeBaru.next = START;
            START = nodeBaru;
            return;
        }
        //menemukan lokasi node baru di dalam list
        Node previous, current;
        previous = START;
        current = START;

        while ((current != null) && (nim >= current.noMhs))
        {
            if (nim == current.noMhs)
            {
                Console.WriteLine("\nNo mahasiswa sama tidak diizinkan\n");
                return;
            }
            previous = current;
            current = current.next;
        }
        //node baru akan ditempatkan diantara previous dan current

        nodeBaru.next = current;
        previous.next = nodeBaru;
    }
    //method untuk menghapus node tertentu didalam list*/
    public bool delNode(int nim)
    {
        Node previous, current;
        previous = current = null;
        /*check apakah node yang dimaksud ada didalam list atau tidak*/
        if (Search(nim, ref previous, ref current) == false)
            return false;
        previous.next = current.next;
        if (current == START)
            START = START.next;
        return true;
    }

    /*Method untuk menge-check apakah node yang dimaksud ada didalam list atau tidak*/
    public bool Search(int nim, ref Node previous, ref Node current)
    {
        previous = START;
        current = current.next;

        while ((current != null) && (nim != current.noMhs))
        {
            previous = current;
            current = current.next;

        }
        if (current == null)
            return (false);
        else
            return (true);
    }
    public void traverse()
    {
        if (listEmpty())
            Console.WriteLine("\nlist kosong. \n");
        else
            Console.WriteLine("\nData didalam list adalah : \n");
            Node currentNode;
            for (currentNode = START; currentNode != null; currentNode = currentNode.next)
            Console.WriteLine(currentNode.noMhs + "" + currentNode.nama + "\n");




        
    }

        }



    }



         

    }
}




