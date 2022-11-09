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

        while ((current != null ) && (nim >= current.noMhs))
        {
            if (nim == current.noMhs)
            {
                Console.WriteLine("\nNo mahasiswa sama tidak diizinkan\n");
                return;
            }
            previous = current;
            current = current.next;

        }
         

    }
}




