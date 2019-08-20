SELECT * FROM UserCart
JOIN MsUser ON MsUser.UserId = UserCart.UserId
JOIN ShoeTable ON ShoeTable.ShoeId = UserCart.ShoeId
--WHERE MsUser.UserId = '6' AND ShoeTable.ShoeId = '1'