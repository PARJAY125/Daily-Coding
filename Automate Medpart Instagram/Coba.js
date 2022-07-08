var isLike = prompt("Apakah disuruh menykai postingan : ");

if (isLike  == true ) console.log("true")
else console.log("false")

// separator

const sleep = (milliseconds) => {
    return new Promise(resolve => setTimeout(resolve, milliseconds))
}

async function automate() {
    filler("Postingan Disukai")
    await sleep(2000)
    filler("Postingan disimpan")
    await sleep(2000)
    filler("Menuju posting selanjutnya")
}

async function filler(comment) {
    if (comment != null) console.log(comment)
    await sleep(2000)
}

// separator
btnLike = undefined, likeResponse = undefined
var isLike = prompt("Apakah disuruh menykai postingan : ");
if (isLike == true ) likeResponse = "Postingan Disukai"

console.log(likeResponse)