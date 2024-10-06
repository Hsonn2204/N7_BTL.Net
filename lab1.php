<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Diện Tích Hình Chữ Nhật</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #ffffff;
        }
        .container {
            width: 400px;
            margin: 100px auto;
            background-color: #f2dfab;
            padding: 20px;
            border-radius: 0px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        h2 {
            background-color: #d49b45;
            color: rgb(241, 26, 26);
            padding: 10px;
            margin-top: 0;
            border-radius: 0px;
        }
        label {
            display: inline-block;
            width: 100px;
            text-align: left;
            font-weight: bold;
        }
        input[type="text"] {
            width: 150px;
            padding: 5px;
            margin-bottom: 10px;
            border: 2px solid #010101;
            border-radius: 0px;
        }
        input[type="submit"] {
            background-color: #737373;
            color: white;
            padding: 8px 20px;
            border: none;
            border-radius: 0px;
            cursor: pointer;
        }
        input[type="submit"]:hover {
            background-color: #c76a1a;
        }
        .result {
            margin-top: 10px;
            font-size: 18px;
            color: #333;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <div class="container">
        <h2>Diện Tích Hình Chữ Nhật</h2>
        <form method="POST" action="">
            <label for="length">Chiều dài:</label>
            <input type="text" id="length" name="length" value="<?php echo isset($_POST['length']) ? $_POST['length'] : ''; ?>"><br>

            <label for="width">Chiều rộng:</label>
            <input type="text" id="width" name="width" value="<?php echo isset($_POST['width']) ? $_POST['width'] : ''; ?>"><br>

            <label for="area">Diện tích:</label>
            <input type="text" id="area" name="area" readonly value="<?php 
                if ($_SERVER['REQUEST_METHOD'] == 'POST' && is_numeric($_POST['length']) && is_numeric($_POST['width'])) {
                    echo $_POST['length'] * $_POST['width'];
                }
            ?>"><br>

            <input type="submit" name="submit" value="Tính">
        </form>
    </div>
</body>
</html>
