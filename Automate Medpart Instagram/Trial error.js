const sleep = (milliseconds) => {
    return new Promise(resolve => setTimeout(resolve, milliseconds))
}

var jmlPostingan = prompt("Masukkan jumlah postingan : ");

actionListContainer = document.getElementsByClassName("_aamu _aat0")[0].getElementsByClassName("_abl-")

var isLike = prompt("Apakah disuruh menykai postingan : ");
btnLike = [0]

var isSave = prompt("Apakah disuruh menyimpan postingan : ");
btnSave = [3]

btnNext = document.getElementsByClassName("_aaqf _aaqh")[0].getElementsByClassName("_abl-")[0]

async function automate() {
    if (isLike  == true ) {
        actionListContainer.btnLike.click()
        filler("Postingan Disukai")
    }
    
    if (isSave == true ) {
        actionListContainer.btnSave.click()
        filler("Postingan disimpan")
    }
    
    btnNext.click()
    filler("Menuju posting selanjutnya")
}

async function filler(comment) {
    if (comment != null) console.log(comment)
    await sleep(2000)
}