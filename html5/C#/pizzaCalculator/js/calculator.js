const slice1 = document.getElementById('slice1');
const slice2 = document.getElementById('slice2');
const slice3 = document.getElementById('slice3');
const slice4 = document.getElementById('slice4');
const button = document.getElementById('button');

const txtResult1 = document.getElementById('txtResult1');
const txtResult2 = document.getElementById('txtResult2');
const txtResult3 = document.getElementById('txtResult3');

button.addEventListener('click', calculate);

var oneSlice;
var twoSlice ;
var threeSlice ;
var fourSlice ;

function calculate(e){
   
   let num1 = slice1.value;
   let num2 =  slice2.value;
   let num3 =  slice3.value;
   let num4 =  slice4.value;

   let oneSlice = e.target.value;

   oneSlice = num1.split(',');
   twoSlice = num2.split(',');
   threeSlice = num3.split(',');
   fourSlice = num4.split(',');
   
   txtResult3.innerHTML =(`Large Pizza: ${Math.ceil((parseInt(oneSlice[2]) + parseInt(twoSlice[2]) + parseInt(threeSlice[2]) + parseInt(fourSlice[2]))/8)}`);
   txtResult2.innerHTML =(`Medium Pizza: ${Math.ceil((parseInt(oneSlice[1]) + parseInt(twoSlice[1]) + parseInt(threeSlice[1]) + parseInt(fourSlice[1]))/6)}`);
   txtResult1.innerHTML =(`Small Pizza: ${Math.ceil((parseInt(oneSlice[0]) + parseInt(twoSlice[0]) + parseInt(threeSlice[0]) + parseInt(fourSlice[0]))/4)}`) ;
}
