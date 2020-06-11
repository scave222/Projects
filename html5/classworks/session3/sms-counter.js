const displayBoard = document.querySelector("#displayBoard");
const txtSMS = document.querySelector("#txtSMS");



txtSMS.addEventListener('keyup', countCharacters);



function countCharacters () {
    let sms = txtSMS.value;
   let smsPieces = sms.split('').length;

 pageCount = Math.floor(smsPieces / 160) + 1;
       totalCharacters = 160 * pageCount;
   

   displayBoard.innerHTML = `Page Count: ${pageCount} (${smsPieces}/${totalCharacters})`;
}
