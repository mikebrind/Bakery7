"use strict";
const unitPriceElement = document.querySelector('#UnitPrice');
const quantityElement = document.querySelector('#Quantity');
const orderTotalElement = document.querySelector('#orderTotal');
if (quantityElement && unitPriceElement && orderTotalElement) {
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
