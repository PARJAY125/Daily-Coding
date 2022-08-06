import java.util.*;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello, World!");
        
        String nama = "mamat nata";
		int selingkuhan = 0;

        if (selingkuhan <= 0)  System.out.println("Aman");
        else if (selingkuhan == 1)  System.out.println("Playboy");
        else  System.out.println("Gak ketolong lagi dah ni anak");

        for (int i = 0; i < 5; i++) {
			System.out.println("perulangan ke-" + i);
		} 
		System.out.println(luasPersegiPanjang(5, 2));
    }

    static int luasPersegiPanjang(int panjang, int lebar) {
        return panjang * lebar;
    }
}