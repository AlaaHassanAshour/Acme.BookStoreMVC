//$(function () {

//    // DELETING ITEMS /////////////////////////////////////////
//    $('#TodoList').on('click', 'li i', function () {
//        var $li = $(this).parent();
//        var id = $li.attr('data-id');
//        todoApp.todo.delete(id).then(function () {
//            $li.remove();
//            abp.notify.info('Deleted the todo item.');
//        });
//    });

//    // CREATING NEW ITEMS /////////////////////////////////////
//    $('#NewItemForm').submit(function (e) {
//        e.preventDefault();

//        var todoText = $('#NewItemText').val();

//        .todo.create(todoText).then(function (result) {
//            $('<li data-id="' + result.id + '">')
//                .html('<i class="fa fa-trash-o"></i> ' + result.text)
//                .appendTo($('#TodoList'));
//            $('#NewItemText').val('');
//        });
//    });
//});
//acme.BookStoreMVC.books.book.getList({}).done(function (result) { console.log(result); });
//acme.BookStoreMVC.authors.author.getList({}).done(function (result) { console.log(result); });
//acme.BookStoreMVC.authors.author.getList({}).done(function (result) { console.log(result); });

//acme.BookStoreMVC.books.book.create({
//    name: 'Foundation',
//    type: 7,
//    publishDate: '1951-05-24',
//    price: 21.5
//}).then(function (result) {
//    console.log('successfully created the book with id: ' + result.id);
//});
//acme.BookStoreMVC.books.book.getList({}).done(function (result) { console.log(result); });

