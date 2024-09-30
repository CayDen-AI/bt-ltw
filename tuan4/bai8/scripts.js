let i = 2;
function thuchien(){
    const getIdTenvxl = document.getElementById("txtTenVXL");
    const getIdHang = document.getElementById("txtHang");
    const getIdNgayramat = document.getElementById("txtNgayramat");
    const getIdGia = document.getElementById("txtGia");

    let cvtToList = getIdNgayramat.value.split("/");
    let getNgay = cvtToList[0];
    let getThang = cvtToList[1];
    let getNam = cvtToList[2];
    let formatDate = "";
    formatDate += getNam + "/" + getThang + "/" + getNgay;
    const currentDate = new Date();
    const releaseDate = new Date(formatDate);
    if (releaseDate > currentDate) {
        alert("Ngày ra mắt không thể lớn hơn ngày hiện tại");
    } else {
        var ngayramat = getIdNgayramat.value;
    }
    
    document.getElementById("table-body").innerHTML += `<tr>
                    <td>${i += 1}</td>
                    <td>${getIdTenvxl.value}</td>
                    <td>${getIdHang.value}</td>
                    <td>${ngayramat}</td>
                    <td>${getIdGia.value}</td>
                </tr>`
}