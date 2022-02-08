function sortByPriceAscending(jsonString) {
  // Yоur cоdе gоеs hеrе
    // console.log(jsonString.name)
    var market_list = JSON.parse(jsonString)
    for(var i = 0, i < market_list.len, i++)
    console.log(market_list[0])

}

console.log(sortByPriceAscending('[{"name":"eggs","price":1},{"name":"coffee","price":9.99},{"name":"rice","price":4.04}]'));