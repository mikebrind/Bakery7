const unitPriceElement = document.querySelector('#UnitPrice') as HTMLInputElement;
const quantityElement = document.querySelector('#Quantity') as HTMLInputElement;
const orderTotalElement = document.querySelector('#orderTotal') as HTMLSpanElement;
if(quantityElement && unitPriceElement && orderTotalElement){
    quantityElement.addEventListener('change', _ => {
        const unitPrice = Number(unitPriceElement.value);
        const quantity = Number(quantityElement.value);
        const orderTotal = unitPrice * quantity;
        orderTotalElement.textContent = orderTotal.toLocaleString('en-GB', {
            style: 'currency',
            currency: 'GBP',
        });
    });
}