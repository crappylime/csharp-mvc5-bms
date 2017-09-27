@model BloodManagmentSystem.Models.DonorConfirmationEmail
To: @Model.Donor.Email 
From: bms.mailingsystem@gmail.com 
Subject: BMS blood request confirmation

<html>

<head>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <title>Mailing service</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
            font-size: 16px;
        }

        .btn {
            color: #ee4c50;
            background: white;
            border: 1px solid white;
            padding: 11px 50px;
            font-weight: bold;
            margin-right: 15px;
            transition: 500ms all;
            cursor: pointer;
            text-decoration: none;
        }

            .btn:hover {
                color: white;
                background: #ea2d32;
                border-color: white;
            }

        h2 {
            padding-top: 15px;
            text-align: center;
            line-height: 40px;
        }
    </style>
</head>

<body>
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <tr>
            <td>
                <table align="center" border="0" cellpadding="0" cellspacing="0" width="600" style="border-collapse: collapse;">
                    <tr>
                        <td bgcolor="#ee4c50" style="color: white;">
                            <h2>Blood Managment System</h2>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" bgcolor="#ec9597" style="padding: 40px 0 30px 0;" height="10"> <img src="https://image.ibb.co/mdo8EQ/blood_drop.png" alt="Creating Email Magic" width="100" style="display: block;" /> </td>
                    </tr>
                    <tr>
                        <td bgcolor="#ee4c50" style="padding: 40px 30px 40px 30px;">
                            <table border="0" cellpadding="0" cellspacing="0" width="100%" style="color: white;">
                                <tr>
                                    <td>
                                        <h3 align="center">Cześć @Model.Donor.Name !</h3>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <p align="center">Dostajesz ten e-mail ponieważ zdecydowałeś się zapisać do BloodDrop.</p>
                                        <p align="center">W tej chwili potrzebujemy twojej krwi aby uratować komuś życie.</p>
                                        <p align="center">Wciśnij Pomagam aby dostać szczegóły dotyczące poboru krwi.</p>
                                        <p align="center">I Pamiętaj: "Don't be afraid to save lifes :)"!</p>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <div align="center" style="padding-top: 30px"> <a href="#" class="btn">Pomagam</a> <a href="#" class="btn">Nie tym razem</a> </div>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#ec9597" style="padding: 30px; font-size: 14px; font-weight: bold; color: white"> &copy; BMS, Codecool 2017 </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</body>

</html>