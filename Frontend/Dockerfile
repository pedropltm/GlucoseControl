# Get the base image from node
FROM node:16.0.0

# Defining the directory where we host our source code.
WORKDIR /app

COPY entrypoint.sh /entrypoint.sh
RUN chmod +x /entrypoint.sh

# Copies the source code from source code on host machine over to container’s /app directory.
ADD . .

# Run "npm install" inside the image.
RUN npm install

# Generate runtime image
ENTRYPOINT ["/entrypoint.sh"]

# Start the application.
CMD ["npm", "run", "dev"]