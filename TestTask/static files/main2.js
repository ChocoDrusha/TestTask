(async () => {
    const array1 = [6, 2, 3, 1, 7, 4, 8, 5];
    const array = await fun();

    async function fun() {
        return await fetch('https://localhost:7131/api/main', {
            method: 'POST',
            headers: {
             'Content-Type': 'application/json;charset=utf-8'
            },
            body: JSON.stringify(array1)
          })
            .then(response => response.json())

    }
    console.log(array);
    DrawArray(array);
    function DrawArray(array) {
        var wrapper = $(".blocks-wrapper");
        wrapper.html('');
     
        array.forEach(element => {
            wrapper.append(`<div class="block" id="block-${element}">${element}</div>`);
        });
        wrapper.addClass('reDrawed');
    
        setTimeout(() => {
            wrapper.removeClass('reDrawed');
        },1000)
    }
})();
