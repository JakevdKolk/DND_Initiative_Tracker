# syntax=docker/dockerfile:1.7
FROM node:20-alpine AS development

WORKDIR /app

# copy only package files first for better caching
COPY package*.json ./

# install deps
RUN npm ci

# copy the rest
COPY . .

# make Vite listen on all interfaces and play nice on Docker/Windows
ENV HOST=0.0.0.0
ENV CHOKIDAR_USEPOLLING=true

# Vite default port
EXPOSE 5173

# run Vite dev server
CMD ["npm", "run", "dev", "--", "--host", "0.0.0.0", "--strictPort", "--port", "5173"]
