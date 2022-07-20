// WARNING - SESUAIKAN KODE DENGAN KONDISI DAN KEBUTUHAN TEMAN-TEMAN

var sponsorship = [
    ["isi pesan teman-teman ketik <br> untuk enter", "emailPenerima@gmail.com"], 
    // pengalman pribadi cek apakah pada pesan temen-temen itu benar enter <br> atau ternyata enter 2 kali <br><br>
    ["pesan ke - 2>", "emailPenerima@gmail.com"], 
    ["pesan ke - 3>", "emailPenerima@gmail.com"], 
    ["pesan ke - 4>", "emailPenerima@gmail.com"], 
    ["dst>", "emailPenerima@gmail.com"]
]

const sleep = (milliseconds) => {
    return new Promise(resolve => setTimeout(resolve, milliseconds))
}

async function action() {
    // tekan tombol tulis pesan
    for (var urutan = 0; urutan < sponsorship.length; urutan++) {
        document.getElementsByClassName("T-I T-I-KE L3")[0].click()
    
        var isiPesan = 0;
        var emailTujuan = 1;
    
        // edit kepada / penerima
        await sleep(500)
        document.getElementsByClassName("vO")[urutan * 3].innerHTML = sponsorship[urutan][emailTujuan] // LOW_Warning - pake email sendiri dulu
        
        // edit email body
        await sleep(500)
        document.getElementsByClassName("Am Al editable LW-avf tS-tW")[urutan].innerHTML = sponsorship[urutan][isiPesan]    // pakai yang ini komentar yang lain kalau mau simpen emailnya di draf dulu
        // document.getElementsByClassName("Am Al editable LW-avf tS-tW")[urutan].innerHTML = sponsorship[0][isiPesan]      // pakai yang ini komentar yang lain kalau mau lansung kirim emailnya

        // edit subject
        await sleep(500)
        document.getElementsByClassName("aoT")[urutan].value = "Pengajuan Permohonan Dana Sponsorship Invention 2022"       // pakai yang ini komentar yang lain kalau mau simpen emailnya di draf dulu
        // document.getElementsByClassName("aoT")[urutan].value = "Pengajuan Permohonan Dana Sponsorship Invention 2022"    // pakai yang ini komentar yang lain kalau mau lansung kirim emailnya
        
        // sisipkan file
        await sleep(500)
        document.getElementsByClassName("a1 aaA aMZ")[0].click()

        // tekan tombol kirim
        await sleep(500)                                                                // komentar kode ini kalau mau simpen emailnya di draf dulu
        document.getElementsByClassName("T-I J-J5-Ji aoO v7 T-I-atl L3")[0].click()     // komentar kode ini kalau mau simpen emailnya di draf dulu

        await sleep(500)
    }
}