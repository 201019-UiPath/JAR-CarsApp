function AddACar()
{
    let car = {};
    car.brandsid = document.querySelector('#brandId').value;
    car.yearsid = document.querySelector('#yearId').value;
    car.price = document.querySelector('#price').value;

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function() {
        if(this.readyState == 4 && this.response > 199 && this.respone < 300)
        {
            alert("New Car Added");
            document.querySelector('#brandId').value = '';
            document.querySelector('#yearId').value = '';
            document.querySelector('#price').value = '';

        }
    };

    xhr.open("POST", 'https://localhost:5001/Cars/add', true)

    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(car));
}

function GetAllCars()
{
    fetch('https://localhost:5001/Cars/get')
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#cars tbody tr').forEach(element => element.remove());
        let table = document.querySelector('#cars tbody');
        for(let i = 0; i < result.length; ++i)
        {
            let row = table.insertRow(table.rows.length);
            let biCell = row.insertCell(0);
            biCell.innerHTML = result[i].brandId;

            let yiCell = row.insertCell(1);
            yiCell.innerHTML = result[i].yearId;

            let priceCell = row.insertCell(2);
            priceCell.innerHTML = result[i].price;

        }
    });
}