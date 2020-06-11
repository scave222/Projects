// Select all elements of interest...

const txtMessage = document.getElementById('txtMessage');
const txtFeedback = document.getElementById('txtFeedback');
const pageCount = document.getElementById('pageCount');

txtMessage.addEventListener('keypress', countCharacters);




// pageCount.innerText = "Page count : ";
//Define the event handler function,.....

function countCharacters(){
	// Get message typed in the textarea
	let message = txtMessage.value;

	

	// Sanitize the retrieved message by taking away repeated spaces and replacing them with a single white space.
	
	// message = message.replace(/\s+/g, ' ');

	//Split sanitized message into word pieces

	let letterPieces = message.split('');

	//Count the total number of words in wordPieces

	let numletters= letterPieces.length;

    let lettersRemaining= eval(160 - numletters);
    

	let page = eval(lettersRemaining/160);



	
for (var i=0; i<numletters; i++){
	if (numletters >= 1 & numletters <= 160){
		pageCount.innerHTML = `Page count: ${parseInt(page + 1)} ( ${numletters} /\ 160)`;} 
		else if (numletters > 160 & numletters <= 320){
			pageCount.innerHTML = `Page count: ${parseInt(page + 3)} ( ${numletters - 160} /\ 160)`;} 
			else {pageCount.innerHTML = `You have exceeded the page required`;}			
		
		}









	
// 	for (var i=0; i<numletters; i++){
// if (numletters >= 1 & numletters <= 160){
// 	txtFeedback.value = `Page count: ${parseInt(page + 1)} ( ${numletters} /\ 160)`;} 
// 	else if (numletters > 160 & numletters <= 320){
// 		txtFeedback.value = `Page count: ${parseInt(page + 3)} ( ${numletters - 160} /\ 160)`;} 
// 		else {txtFeedback.value = `You have exceeded the page required`;}
        
    
// 	}

	



// for (var i=0; i<numletters; i++){
// 	if (numletters >= 1 & numletters <= 160) {
// 		txtFeedback.style.background = "green"; }
// 		else if(numletters > 160 & numletters <= 320){
// 			txtFeedback.style.background = "orange";} 
// 			else{txtFeedback.style.background = "red"}

// 		}
    }
        
    

    
   


