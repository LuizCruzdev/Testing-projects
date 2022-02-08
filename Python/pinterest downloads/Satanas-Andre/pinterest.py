import requests
from bs4 import BeautifulSoup

with open('images.html') as f:
    html = f.read()

print(html)