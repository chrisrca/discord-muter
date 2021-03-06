from multiprocessing.connection import wait
from numpy import full
import pytesseract
import cv2
import pyautogui
import os
from echoclient import *

#16:9
#pyautogui.screenshot('screenshot.png', region = (1778, 97, 59, 32))

#4:3
pyautogui.screenshot('screenshot.png', region = (1738, 97, 69, 32))

pytesseract.pytesseract.tesseract_cmd = 'C:\Program Files\Tesseract-OCR\\tesseract.exe'

img = cv2.imread("screenshot.png")
os.remove("screenshot.png")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
ret, thresh1 = cv2.threshold(gray, 0, 255, cv2.THRESH_OTSU | cv2.THRESH_BINARY_INV)
rect_kernel = cv2.getStructuringElement(cv2.MORPH_RECT, (18, 18))
dilation = cv2.dilate(thresh1, rect_kernel, iterations = 1)

contours, hierarchy = cv2.findContours(dilation, cv2.RETR_EXTERNAL,
cv2.CHAIN_APPROX_NONE)
im2 = img.copy()

fullstring = ""

for cnt in contours:
    x, y, w, h = cv2.boundingRect(cnt)

    rect = cv2.rectangle(im2, (x, y), (x + w, y + h), (0, 255, 0), 2)

    cropped = im2[y:y + h, x:x + w]

    text = pytesseract.image_to_string(cropped)
    fullstring = fullstring + text

substring1 = "Jwal"
substring2 = "Jwa"
substring3 = "wal"
substring4 = "Swat"

if substring1 in fullstring: 
    sendDied()
elif substring2 in fullstring:
    sendDied()
elif substring3 in fullstring:
    sendDied()
elif substring4 in fullstring:
    sendDied()
