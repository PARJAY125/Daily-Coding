#include <stdio.h>

int luasPersegiPanjang(int panjang, int lebar) {
    return panjang * lebar;
}

int main() {
    printf("Hello, World!\n");

    char nama[] = "mamat nata";
	int selingkuhan = 0;

    if (selingkuhan <= 0)  printf("Aman");
    else if (selingkuhan == 1)  printf("Playboy");
    else  printf("Gak ketolong lagi dah ni anak");
    printf("\n");

    for (int i = 0; i < 5; i++) {
        printf("perulangan ke-%d\n", i);
    } 
    printf(luasPersegiPanjang(5, 2));
}   