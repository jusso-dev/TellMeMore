FROM python:3.7.5-alpine

COPY . /app
WORKDIR /app
RUN cd /app
RUN pip install flask
RUN pip install flask_restful
RUN pip install dnsdumpster
ENTRYPOINT [ "python" ]
CMD [ "main.py" ]