// Select all elements of interest...

const txtMessage = document.getElementById('txtMessage');
const txtFeedback = document.getElementById('txtFeedback');
const pageCount = document.getElementById('pageCount');

txtMessage.addEventListener('keypress', countWords);




// pageCount.innerText = "Page count : ";
//Define the event handler function,.....

function countWords(){
	// Get message typed in the textarea
	let message = txtMessage.value;

	

	// Sanitize the retrieved message by taking away repeated spaces and replacing them with a single white space.
	
	message = message.replace(/\s+/g, ' ');

	//Split sanitized message into word pieces

	let wordPieces = message.split(' ');

	//Count the total number of words in wordPieces

	let numWords= wordPieces.length;

	let wordsRemaining= eval(250 - numWords);

if (wordsRemaining < 0) {
	txtFeedback.value = "Sorry, you have exceeded the maximum number of words allowed!";
} else{
	txtFeedback.value = `You have ${wordsRemaining} remaining...`;
}


if (wordsRemaining < 10) {
	txtFeedback.style.background = "red"; }
	else if(wordsRemaining < 50){
		txtFeedback.style.background = "orange";} 
		else{txtFeedback.style.background = "gray"}



		// var list = document.getElementsByTagName("p")[0].innerHTML="Whatever text! ggg";

	 }
	
	 