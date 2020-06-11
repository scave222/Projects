// All valid credit card numbers
const valid1 = "4539 6779 0801 6808";
const valid2 = "5535 7667 6875 1439";
const valid3 = "3716 1201 9985 236";
const valid4 = "6011 1443 4068 2905";
const valid5 = "4539 4049 6786 9666";

// All invalid credit card numbers
const invalid1 = "4532 7787 7109 1795";
const invalid2 = "5795 5933 9213 4643";
const invalid3 = "3757 9608 4459 914";
const invalid4 = "6011 1279 6177 7935";
const invalid5 = "5382 0197 7288 3854";

// Can be either valid or invalid
const notCertain1 = "3448 0196 8305 414";
const notCertain2 = "5466 1008 6162 0239";
const notCertain3 = "6011 3770 2096 2656 203";
const notCertain4 = "4929 8771 6921 7093";
const notCertain5 = "4913 5404 6307 2523";

// An array of all the arrays above

const batch = [valid1, valid2, valid3, valid4, valid5, invalid1, invalid2, invalid3, invalid4, invalid5, notCertain1, notCertain2, notCertain3, notCertain4, notCertain5]

// Add your functions below:

function transformStrArr() {
    for (var i = 0; i < batch.length; i++){
        
        
            var a = batch[i].split(' ').join('').split('');  
        function validateCard(a) {
            var numSum = 0;
            var value = 0;
            for (var i = a.length -1; i >=0 ; i--) {
                    if(i % 2 == 0){
                    value = 2 * a[i];
                    if (value >= 10) {
                        value = (value - 9);
                    }
                } else {
                    value = +a[i];
                }
                numSum += value;
             
        }
            return (numSum % 10 == 0);
            
           

        }       
         console.log(a);
        // console.log(validateCard(a));
        console.log(validateCard(valid4));  
    } 
    
 }
 transformStrArr();


// let nestedArray = [
//     [4,5,3,9,6,7,7,9,0,8,0,1,6,8,0,8],
//     [5,5,3,5,7,6,6,7,6,8,7,5,1,4,3,9],
//     [3,7,1,6,1,2,0,1,9,9,8,5,2,3,6],
//     [4,5,3,2,7,7,8,7,7,1,0,9,1,7,9,5],
//     [5,7,9,5,5,9,3,3,9,2,1,3,4,6,4,3],
//     [4,5,3,9,4,0,4,9,6,7,8,6,9,6,6,6],      
//     [6,0,1,1,1,4,4,3,4,0,6,8,2,9,0,5],
//     [3,7,5,7,9,6,0,8,4,4,5,9,9,1,4],
//     [6,0,1,1,1,2,7,9,6,1,7,7,7,9,3,5],
//     [5,3,8,2,0,1,9,7,7,2,8,8,3,8,5,4],
//     [3,4,4,8,0,1,9,6,8,3,0,5,4,1,4],
//     [5,4,6,6,1,0,0,8,6,1,6,2,0,2,3,9],
//     [6,0,1,1,3,7,7,0,2,0,9,6,2,6,5,6,2,0,3],
//     [4,9,2,9,8,7,7,1,6,9,2,1,7,0,9,3],
//     [4,9,1,3,5,4,0,4,6,3,0,7,2,5,2,3]       
// ]



// function findInvalidCards() {
//     let invalidCard = [];
//     for (var i = 0; i <=batch.length ; i++){
//         if (transformStrArr().validateCard(a)[i] == false){
//             invalidCard.push(a[i])
//         }
//     }return invalidCard
// }
// console.log(findInvalidCards(nestedArray));


// function  transformStrArr(string){
//     let arrSplitted = Array.from(string.replace(/\s/g, ""));
    
//     let arr =[];

//     for(i = 0; i < arrSplitted.length; i++){        
//             arr.push(parseInt(arrSplitted[i]))
            
//     }
//     return arr;
// }
// console.log(transformStrArr(notCertain1));
// let result = transformStrArr(notCertain1);
// function validateCard(arr){
//     var single = 0;
//     var double = [];
//     var total = [];
//     var  sum = 0;
    
//            for(i = arr.length - 1; i >= 0; i-=2){
//                     single += arr[i]        
//            }
//            //console.log(single)
           
//            for(i = arr.length - 2; i >= 0; i -= 2){
//                    double.push(arr[i])
                   
//            }
//           var doub = double.map(x => x*2)
//            //console.log(doub)

//            var newDoub = doub.map(x =>{
//                    if(x > 9){
//                            return x - 9
//                    }
//                    else{
//                            return x
//                    }
//            })
//                    // console.log(newDoub);

//                    var newDouble = newDoub.reduce((x,y) => {
//                            return x+y
//                     })

//                    // console.log(newDouble);

//             total = single + newDouble;
//             //console.log(total);
//             if(total % 10 !=0){
//                     return false
//             }
//             return true
// }
            
// console.log(validateCard(transformStrArr(notCertain3)))
// let nestedArray = [
//     [4,5,3,9,6,7,7,9,0,8,0,1,6,8,0,8],
//     [5,5,3,5,7,6,6,7,6,8,7,5,1,4,3,9],
//     [3,7,1,6,1,2,0,1,9,9,8,5,2,3,6],
//     [4,5,3,2,7,7,8,7,7,1,0,9,1,7,9,5],
//     [5,7,9,5,5,9,3,3,9,2,1,3,4,6,4,3],
//     [4,5,3,9,4,0,4,9,6,7,8,6,9,6,6,6],      
//     [6,0,1,1,1,4,4,3,4,0,6,8,2,9,0,5],
//     [3,7,5,7,9,6,0,8,4,4,5,9,9,1,4],
//     [6,0,1,1,1,2,7,9,6,1,7,7,7,9,3,5],
//     [5,3,8,2,0,1,9,7,7,2,8,8,3,8,5,4],
//     [3,4,4,8,0,1,9,6,8,3,0,5,4,1,4],
//     [5,4,6,6,1,0,0,8,6,1,6,2,0,2,3,9],
//     [6,0,1,1,3,7,7,0,2,0,9,6,2,6,5,6,2,0,3],
//     [4,9,2,9,8,7,7,1,6,9,2,1,7,0,9,3],
//     [4,9,1,3,5,4,0,4,6,3,0,7,2,5,2,3]       
// ]
           
            
            
// function findInvalidCards(arr1){
//     let invalidCard = [];
//     for(let i = 0; i < arr1.length; i++){
//             if(validateCard(arr1[i]) === false){
//                      invalidCard.push(arr1[i])
//             }
//     }
//     return invalidCard;
// }
// console.log(findInvalidCards((nestedArray)))
// function idInvalidCardIssuers(arr2){
//     let invalidCardIssuer = []
    
//     for(var i = 0; i < arr2.length; i++){
            
//                     if(arr2[i][0] === 3){
//                             if(invalidCardIssuer.includes("Amex") === false)
//                             invalidCardIssuer.push("Amex")
//                     }
//                     else if(arr2[i][0] === 4){
//                             if(invalidCardIssuer.includes("Visa") === false)
//                             invalidCardIssuer.push("Visa")
//                     }
//                     else if(arr2[i][0] === 5){
//                             if(invalidCardIssuer.includes("Mastercard") === false)
//                             invalidCardIssuer.push("Mastercard")
//                     }
//                     else if(arr2[i][0] === 6){
//                             if(invalidCardIssuer.includes("Discover") === false)
//                             invalidCardIssuer.push("Discover")
//                     }
//                     else{
//                             document.write("Card Issuer not found")
//                     }
            
//     }
//     return invalidCardIssuer;
    
// }
// console.log(idInvalidCardIssuers(findInvalidCards((nestedArray))));
// Collapse




















