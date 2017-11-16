// Write your JavaScript code.
$(document).ready(function () {
    $('#rooms-form').hide();
    $('#view-rooms-button').on('click', showRooms);

    $('#bookings-form').hide();
    $('#view-bookings-button').on('click', showBookings);

    $('#guests-form').hide();
    $('#view-guests-button').on('click', showGuests);

    $('#billing-form').hide();
    $('#view-billing-button').on('click', showBilling);

    $('#add-bill-button').on('click', addBill);
    $('#add-room-button').on('click', addRoom);
    $('#add-booking-button').on('click', addBooking);
    $('#add-guest-button').on('click', addGuest);

});

function showRooms() {
    $('#rooms-form').show();
}
function showBilling() {
    $('#billing-form').show();
}
function showBookings() {
    $('#bookings-form').show();
}
function showGuests() {
    $('#guests-form').show();
}