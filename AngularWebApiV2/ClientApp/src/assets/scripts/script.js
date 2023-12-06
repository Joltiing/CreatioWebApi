document.addEventListener('DOMContentLoaded', function () {
  document.getElementsByName('method').forEach(function (elem) {
    elem.addEventListener("change", function (event) {
      document.getElementById('getAllUsersDiv').style.display = 'none';
      document.getElementById('getUserDiv').style.display = 'none';
      document.getElementById('createUserDiv').style.display = 'none';
      document.getElementById('deactivateUserDiv').style.display = 'none';
      document.getElementById('activateUserDiv').style.display = 'none';
      document.getElementById(event.target.value + 'Div').style.display = 'block';
    });
  });
});
