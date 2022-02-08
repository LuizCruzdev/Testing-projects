import requests
from bs4 import BeautifulSoup
import os

url = "https://br.pinterest.com/"

r = requests.get(url)

soup =  BeautifulSoup(r.text, "html.parser")

images = soup.find_all('img')

print(images)