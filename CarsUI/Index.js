function AddACar()
{
    let car = {};
    car.brandsid = document.querySelector('#brandsid').value;
    car.yearsid = document.querySelector('#yearsid').value;
    car.price = document.querySelector('#price').value;

    let xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function() {
        if(this.readyState == 4 && this.response > 199 && this.respone < 300)
        {
            alert("New Car Added");
            document.querySelector('#brandsid').value = '';
            document.querySelector('#yearsid').value = '';
            document.querySelector('#price').value = '';

        }
    };

    xhr.open("POST", 'https://localhost:44356/Car/add', true)

    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.send(JSON.stringify(car));
}

function GetAllCars()
{
    fetch('https://localhost:44356/Car/get')
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#cares tbody tr').forEach(element => element.remove());
        let table = document.querySelector('#cares tbody');
        for(let i = 0; i < result.length; ++i)
        {
            let row = table.insertRow(table.rows.length);
            let biCell = row.insertCell(0);
            biCell.innerHTML = result[i].brandsid;

            let yiCell = row.insertCell(1);
            yiCell.innerHTML = result[i].yearsid;

            let priceCell = row.insertCell(2);
            priceCell.innerHTML = result[i].price;

        }
    });
}