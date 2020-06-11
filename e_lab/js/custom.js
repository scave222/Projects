// slider

const slides = document.querySelectorAll('ul li.slide');
console.log(slides);

let currentSlide = 0;

let interval = setInterval(changeSlide, 4000);

function changeSlide() {
	slides[currentSlide].setAttribute('class', 'slide');
	currentSlide = (currentSlide + 1) % slides.length;
	slides[currentSlide].setAttribute('class', 'slide active');
}

// eliberary
const addBtn = document.getElementById('addBtn');
const cancelBtn = document.getElementById('cancelBtn');
let bookModal = document.getElementById('bookModal');

addBtn.addEventListener('click', function() {
	// let bookModal = document.getElementById("bookModal");
	bookModal.style.display = 'block';
});

cancelBtn.addEventListener('click', function() {
	// let bookModal = document.getElementById("bookModal");
	bookModal.style.display = 'none';
});

const newBookBtn = document.getElementById('newBookBtn');
const txtTitle = document.getElementById('txtTitle');
const txtPub = document.getElementById('txtPub');
const txtPages = document.getElementById('txtPages');
const txtPubYear = document.getElementById('txtPubYear');
const txtCoverURL = document.getElementById('txtCoverURL');
const bookRow = document.getElementById('bookRow');
const eLibrary = [];

newBookBtn.addEventListener('click', addToELibrary);

function Book(title, pub, pages, yearPub, coverImgUrl) {
	this.title = title;
	this.pub = pub;
	this.pages = pages;
	this.yearPub = yearPub;
	this.coverImgUrl = coverImgUrl;
}

function addToELibrary() {
	if (validateInput()) {
		let title = txtTitle.value;
		let pub = txtPub.value;
		let pages = txtPages.value;
		let coverImgURL = txtCoverURL.value;
		let yearPub = txtPubYear.value;
		let book = new Book(title, pub, pages, yearPub, coverImgURL);
		//    eLibrary.push(book)
		saveBook(book);
		location.reload();
		bookRow.innerHTML += `
   <div class="col-md-4">
   <div class="card">
      <div class="book-cover">
       <img src="${booksArray[i].coverImgURL}" class="card-img img-fluid"/>
      </div>
       <div class="card-body">
           <h3 class="card-title">${booksArray[i].title}</h3>
           <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas, ratione.</p>
           <span class="btn btn-primary">Read Book</span>
       </div>          
     </div>
</div>
     `;
	} else {
		alert('Sorry all inputs must be filled ');
	}
}

function validateInput() {
	if (txtTitle.value == '' || txtPub.value == '' || txtPubYear.value == '' || txtPages.value == '') {
		return false;
	}
	return true;
}

function render() {
	if (localStorage.getItem('books') != null) {
		let booksArray = JSON.parse(localStorage.getItem('books'));
		for (var i = 0; i < booksArray.length; i++) {
			bookRow.innerHTML += `
            <div class="col-md-4">
               <div class="card">
                  <div class="book-cover">
                   <img src="${booksArray[i].coverImgURL}" class="card-img img-fluid"/>
                  </div>
                   <div class="card-body">
                       <h3 class="card-title">${booksArray[i].title}</h3>
                       <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas, ratione.</p>
                       <span class="btn btn-primary">Read Book</span>
                   </div>          
                 </div>
            </div> `;
		}
	} else {
		console.log('no books yet');
	}
}
//     if(eLibrary.length > 0){
//         console.log('hi')
//         for(var i= 0; i < eLibrary.length; i++){
//             bookRow.innerHTML +=          `
//          <div class="col-md-4">
//             <div class="card">
//                <div class="book-cover">
//                 <img src="${eLibrary[i].coverImgURL}" class="card-img img-fluid"/>
//                </div>
//                 <div class="card-body">
//                     <h3 class="card-title">${eLibrary[i].title}</h3>
//                     <p class="card-text">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Voluptas, ratione.</p>
//                     <span class="btn btn-primary">Read Book</span>
//                 </div>
//               </div>
//          </div>
//                                     `
//         }
//     }
// }

function saveBook(bookObj) {
	let booksArray = [];
	if (localStorage.getItem('books') === null) {
		booksArray.push(bookObj);
		localStorage.setItem('books', JSON.stringify(booksArray));
		alert('New book added to the eLibrary');
	} else {
		booksArray = JSON.parse(localStorage.getItem('books'));
		booksArray.push(bookObj);
		localStorage.setItem('books', JSON.stringify(booksArray));
		alert('New book added to the eLibrary');
	}
}

// render();
