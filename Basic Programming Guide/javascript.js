console.log("Hello, World!");

var nama = "mamat nata";
var selingkuhan = 0;

if (selingkuhan <= 0) console.log("Aman");
else if (selingkuhan == 1) console.log("Playboy");
else console.log("Gak ketolong lagi dah ni anak");

for (var i = 0; i < 5; i++) {
    console.log("perulangan ke-" + i);
} 
console.log(luasPersegiPanjang(5, 2));

function luasPersegiPanjang(panjang, lebar) {
    return panjang * lebar;
}