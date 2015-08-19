/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
//function solve() {
	var library = (function () {
		var books = [];
		var categories = [], filtred =[];

		function listBooks() {
			var m;
			var args = arguments[0];
			if(books.length === 0){
				return [];
			}
			if(books.length === 1){
				// Important: the check for !args should be before trying to check args.category
				// otherwise if args is undefind, trying to read property of undefind will lead to Type Error
				if(!args ||books[0].category === args.category){
					return books;
				}
				else{
					return [];
				}
			}

			if(args) {
				filtred = books.filter(function (b) {
					return b.category === args.category;
				});
			}
			else{
				filtred = books;
			}
			return filtred.sort(function(a,b){
				return a.ID- b.ID;
			})

			return books;
		}

		function addBook(book) {
			var isUnique = true, booksLen = books.length;
			book.ID = books.length + 1;
			if (book.title.length < 2 || book.title.length > 101) {
				throw new Error;
			}
			if (book.author === '') {
				throw new Error;
			}
			//if (book.isbn.length !== 10 && book.isbn.length !== 13) {
			//	throw new Error;
			//}
			if (isNaN((book.isbn))) {
				throw new Error;
			}
			if (books.length > 0) {
				for (var i = 0; i < booksLen; i += 1) {
					if (books[i].title === book.title || books[i].isbn === book.isbn ) {
						isUnique = false;
						throw new Error;
					}
				}
			}
			var k, catLen = categories.length;
			for (k =0; k < catLen; k+=1){
				if (categories[k] === book.category){
					break;
				}
				if (k === catLen -1){
					categories.push(book.category);
				}
			}


			if (isUnique === true) {
				books.push(book);
			}

			return book;
		}

		function listCategories() {
			var len = books.length, p;
			for (p = 0; p< len; p+=1)
			{
				if (categories.indexOf(books[p].category)===-1){
					categories.push(books[p].category);
				}
			}
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
//return library;
//}

//module.exports = solve;


var book = {
	title: 'BOOK#',
	isbn: 1234567890,
	author: 'John Doe',
	category: 'new category'
};
library.books.add(book);
library.categories.list();

//solve(book);
